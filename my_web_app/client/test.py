from zeep import Client

client = Client('https://buntun.azurewebsites.net/WebService.asmx')
print('Enter Data')
print('Room :')
room = input()
print('temperature :')
temp = input()
print('humidity :')
humidity = input()
print('Time')
time = input()
##print(room , temp, humidity , time)
print(client.service.Add_data(room , temp, humidity , time))

client = zeep.Client('https://buntun.azurewebsites.net/WebService.asmx')
print(client.service.show_data())
