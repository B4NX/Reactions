SELECT reactionTypeID,typeID,quantity FROM Mosaic.dbo.invTypeReactions WHERE input = 1;

--SELECT ITEMS.typeID, ITEMS.typeName FROM Mosaic.dbo.invTypeReactions AS REACTIONS, Mosaic.dbo.invTypes AS ITEMS WHERE REACTIONS.reactionTypeID = ITEMS.typeID;

(SELECT Items.typeID,typeName FROM Mosaic.dbo.invTypes AS Items INNER JOIN Mosaic.dbo.invTypeReactions AS Reactions ON Reactions.reactionTypeID = Items.typeID)

