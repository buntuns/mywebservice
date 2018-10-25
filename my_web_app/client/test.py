from zeep import Client

client = Client('http://localhost:54368/WebService.asmx?WSDL')
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

client = zeep.Client('http://localhost:54368/WebService.asmx?WSDL')
print(client.service.show_data())
