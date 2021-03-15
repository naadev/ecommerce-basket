Feature: BasketCase
	Simple calculator for a basket supporting class

Scenario: Empty Baket
	Given an empty basket 
	Then total ammount to pay will be '0.0'

Scenario Outline: Given a basket of n items, and price for this item is x, total will be calculated
		Given a basket with '<items>' items and price for this item is '<price>'
		Then total ammount to pay will be '<total>'
	Examples: 
		| items | price | total |
		| 1     | 1.3   | 1.3   |
		| 2     | 1.3   | 2.6   |
		| 3     | 1.3   | 3.9   |
		| 4     | 1.3   | 5.2   |
		| 5     | 1.3   | 6.5   |

Scenario Outline: Given a basket of n items, and price for this item is x and item discount total will be calculated
		Given a basket with '<quantity>' items and price for this item is '<price>'
		And discount of <discount>% is applied on item price
		Then total ammount to pay will be '<total>'
	Examples: 
		| quantity | price | discount | total |
		| 1        | 1.3   | 10       | 1.17  |
		| 2        | 1.3   | 10       | 2.34  |
		| 3        | 1.3   | 10       | 3.51  |
		| 4        | 1.3   | 10       | 4.68  |
		| 5        | 1.3   | 10       | 5.85  |