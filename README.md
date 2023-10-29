# PcapKeyInjector

This is a utility tool that simplifies the integration of TLS key files into Wireshark captures.

With integrated keys, you can share the capture files with other users in one single file. After
the intergation the file will contain the TLS secrets which allows Wireshark to decrypt the TLS communication
in the capture file.

## Requirements

- Dot Net Framework 4.7.2
- Wireshark installation

## Usage

Enter the path to the editcap.exe from your Wireshark installation to the program settings.
Modify the output filename pattern and the output directory to your own requirements.
As filename pattern you can use {1} for the Wireshark capture filename, and {2} for the
keylog filename, which will be replaced by the entered files.
You can either drag&drop a file onto the (coloured) fields, enter the filenames manually, or use the browse
file dialog buttons.

By clicking on "Inject", editcap.exe from the Wireshark installation is used to inject the TLS secrets
from the .log file into the .pcapng file, and saves all together to a new file.

![Pcap Key Injector running](https://github.com/thomas-v2/PcapKeyInjector/blob/master/images/PcapKeyInjector.png)

In the background the program is calling editcap.exe with this parameters:
```
editcap.exe --inject-secrets tls,keylog.log capture.pcapng capture-with-keys.pcapng
```
This can also be done manually on the command line, but the program simplifies it with a graphical user interface.

## Keylog file

The keylog file with the secrets of the TLS protocol can be saved in OpenSSL by using the SSL_CTX_keylog callback
method, where you can save the private keys.

The keylog file will contain 5 lines, which start with the following identifiers:

```
SERVER_HANDSHAKE_TRAFFIC_SECRET xxx
EXPORTER_SECRET xxx
SERVER_TRAFFIC_SECRET_0 xxx
CLIENT_HANDSHAKE_TRAFFIC_SECRET xxx
CLIENT_TRAFFIC_SECRET_0 xxx
```

## License

GNU Lesser General Public License, Version 3 or later.

## Authors

* **Thomas Wiens** - *Initial work* - [thomas-v2](https://github.com/thomas-v2)
