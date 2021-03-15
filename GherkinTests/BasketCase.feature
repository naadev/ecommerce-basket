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
Scenario: Given an item with price 1.3 and 20% discount, Then discount is applied And total price will be 1.04
		Given a basket with one item and price for this item is '1.3'
		And discount of 20% is applied on item price
		Then total ammount to pay will be '1.04'
        