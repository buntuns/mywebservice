import zeep
client = 'http://localhost:54368/WebService.asmx?WSDL'
client = zeep.Client('http://localhost:54368/WebService.asmx?WSDL')
print(client.service.Show_data())
