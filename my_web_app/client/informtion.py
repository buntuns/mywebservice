from zeep import Client

client = Client('http://localhost:54368/WebService.asmx?WSDL')
print('Enter your information')
print('Your name :')
name = input()
print('Your address :')
address = input()
print('Product weight :')
weight = input()
print(name, address ,weight)
##print(room , temp, humidity , time)
print(client.service.Add_to_store(name , address, weight ))

