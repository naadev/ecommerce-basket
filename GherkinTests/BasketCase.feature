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
        