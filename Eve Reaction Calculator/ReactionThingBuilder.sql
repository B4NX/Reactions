SELECT ITEMS.typeName, ITEMS.typeID FROM Mosaic.dbo.invTypeReactions AS REACTIONS, Mosaic.dbo.invTypes AS ITEMS WHERE REACTIONS.reactionTypeID = ITEMS.typeID;


--SELECT Items.typeName FROM Mosaic.dbo.invTypeReactions AS Reactions, Mosaic.dbo.invTypes AS Items WHERE Reactions.reactionTypeID = Items.typeID

--SELECT Item.typeName, Reaction.typeID FROM Mosaic.dbo.invTypeReactions, Mosaic.dbo.invTypes AS Reaction WHERE Reaction.input = 1

--SELECT Items.typeName FROM Mosaic.dbo.invTypeReactions AS Reactions, Mosaic.dbo.invTypes AS Items WHERE Reactions.reactionTypeID = Items.typeID
--UNION ALL
--SELECT Item.typeName FROM Mosaic.dbo.invTypeReactions AS Reaction, Mosaic.dbo.invTypes AS Item WHERE Reaction.input= 1;
