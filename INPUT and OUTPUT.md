#INPUT

CreateFlowerStore MyStore

FlowerStoreInfo MyStore

TestInvalid

AddFlower tulip red 3.40 MyStore

AddFlower rose yellow 8.70 MyStore

FlowerStoreInfo MyStore

SellFlower tulip red 3.40 MyStore

FlowerStoreInfo MyStore

AddFlower dahlia white 2.40 MyStore

AddFlower narcissus yellow 3.50 MyStore

FlowerStoreInfo MyStore

CalculateTotalPrice MyStore

SellAllFlowers MyStore

CalculateTotalPrice MyStore

FlowerStoreInfo MyStore

RenameFlowerStore MyStore MyNewStore

FlowerStoreInfo MyNewStore

AddFlower rose black 12.30 MyNewStore

AddFlower gladiolus pink 3.50 MyNewStore

GetFlowerWithHighestPrice MyNewStore

AddFlower tulip orange 2.20 MyNewStore

GetFlowerWithLowestPrice MyNewStore

CreateFlowerStore NewestStore

FlowerStoreInfo NewestStore

STOP



#EXPECTED OUTPUT

You created flower store MyStore.

Flower store MyStore has no available flowers.

Invalid command!

You added flower tulip with color red to store MyStore.

You added flower rose with color yellow to store MyStore.

Flower store MyStore has 2 flower/s:

Flower tulip with color red costs 3.40

Flower rose with color yellow costs 8.70

You sold flower tulip with color red from flower store MyStore.

Flower store MyStore has 1 flower/s:

Flower rose with color yellow costs 8.70

You added flower dahlia with color white to store MyStore.

You added flower narcissus with color yellow to store MyStore.

Flower store MyStore has 3 flower/s:

Flower rose with color yellow costs 8.70

Flower dahlia with color white costs 2.40

Flower narcissus with color yellow costs 3.50

Total price: 14.60

You sold all flowers from store MyStore.

Total price: 0.00

Flower store MyStore has no available flowers.

You renamed your store from MyStore to MyNewStore.

Flower store MyNewStore has no available flowers.

You added flower rose with color black to store MyNewStore.

You added flower gladiolus with color pink to store MyNewStore.

Flower from store MyNewStore has highest price: 12.30

You added flower tulip with color orange to store MyNewStore.

Flower from store MyNewStore has lowest price: 2.20

You created flower store NewestStore.

Flower store NewestStore has no available flowers.



#INPUT number 2

CreateFlowerStore a

CreateFlowerStore ab

CreateFlowerStore abc

CreateFlowerStore abcd

CreateFlowerStore stored

AddFlower dahlia white 2.40 stored

AddFlower narcissus yellow 3.50 stored

RenameFlowerStore stored s

RenameFlowerStore stored st

RenameFlowerStore stored sto

RenameFlowerStore stored stor

RenameFlowerStore stored stored1

STOP



#EXPECTED OUTPUT number 2

Invalid flower store name!

Invalid flower store name!

Invalid flower store name!

Invalid flower store name!

You created flower store stored.

You added flower dahlia with color white to store stored.

You added flower narcissus with color yellow to store stored.

Invalid flower store name!

Invalid flower store name!

Invalid flower store name!

Invalid flower store name!

You renamed your store from stored to stored1.

