import zeep
client = 'https://buntun.azurewebsites.net/WebService.asmx'
client = zeep.Client('https://buntun.azurewebsites.net/WebService.asmx')
print(client.service.Show_data())
