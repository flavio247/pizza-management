Pizza management system 

A pizza chef requests an automated system by which he does not have 
to answer the phone to take orders. He requests a system by which the 
customer chooses one or more pizzas from the pizzeria menu and the 
order is recorded in the system.  

The first customer to order a pizza is the first to be served. 
The pizzeria menu is static and contains 4 pizzas: 
• Margherita -> 5€ 
• Ortolana -> 6€ 
• Diavola -> 6.50€ 
• Bufalina -> 7€ 

The company expects to make a REST call to an endpoint to complete 
an order. 
An order must contain at least one pizza from the menu. 
The response returns the identifier of the order just created, the total price 
of the order, and the number of pending orders yet to be filled (excluding 
the one just placed). The pizza maker expects an endpoint that allows him 
to retrieve the next order to be prepared, following the order arrival 
sequence: the oldest order is the first to be filled.