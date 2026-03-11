using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Xunit;

namespace Amazon.DNXCore.IntegrationTests.IntegrationTests
{
    public class DynamoDBTruncateError
    {
        private static string _body = @"e4rnXgCcvCUxikumATfp
iVnXVlDoyRKwTfDAJady
7khZ5t8cH5jbQgMZ8Mt9
1H2Rw0DiUKjPPuA9c54a
DfVUOuAzBa04bL8RKqFU
70kFqwSB9gIkq2qUxLnN
jdGTJH1x5Z5rY146qHFo
cyYYtu6opD6Usd1JKQbs
mmF4580y5QLXWWiVPcOf
1DMW6H04vHSrMB341H7d
rGmnOxj89cAGMGXfWhru
iGl7JjQxhW4Vxy7QRi6Q
atu00Mg2MDlak9Wq41pF
tDUCiBwBuYSLCQWctCAZ
PxHa4lVfmiNh0x2RFSVr
Mo1ThvU8mjQts92ALdG3
lVusVql8eMQmLGox4Rkg
EyvVqBZNXSFyhB3qYKzO
Zu8ow3InXjZD4cU13Yao
s1qz8CTqBgRgaXMlwppc
82kOafDuJl4Sb3SQYyvW
AZ96J6oTHkjk5VYe0KUY
3jlJ6kzsEurqHxHrmKG3
cfYgXwB26GPBOGGKiDYI
HGgJgNkLf4Cr9ybD5Xsu
m5kLfyJbCzk8ClJhH2YB
jdiAe5fQiFhN4AUjJA1T
pogj6UmswqX5XaCVAyTs
GFBSfXqMXMmUnwyLmMBC
ONCJLV4mLsaG3DZcGIlu
zW0VE2elqTaflLVGGwFM
5jHrt6NpuSjsViGlo5II
EwxfwXbVo6nmmkgfYhod
0WyqYgGK0D1tFYS6v62c
NGgpOCJRIyAywbC2HItm
8gSW0d3RFxxewk8lmcuT
qfuQIhAUYIk45JOsuFI1
zAD4MWZcz0XuX6CeOq05
ROM5mfXqmSaK0lSbXsQq
HEAdvpZdZgf0NqJMihdm
uwDeWpyPIu6sRVPzAvDd
ZNsvwCJnpYauSMdNn1Mq
KDyARylXsFaAs7TzNapD
dmiajwAnaWH4uw2IRj0E
mBP03mMyPR1CbtklHNGf
h4iDq60r1vOfU3ESi5nV
cufT5ewnyzPxk8By7Xy7
01BS5CsZEuAAy1Qf5BXt
Hx5tBuqrq5EvDm9IYOH5
udHWMVzxB91t4S7TLFWE
3E20b2CkqFlEJZ07tkuK
5YGomelVnAeNvQgpBSzz
Jgn3ejL3ZzOoi5dd3S4o
n9ZPGjJKKsDPZXWBwO4Y
b0K3xFOixASITN3KxR1o
elRX9WXHqoC65dPStR2w
cFXYqbQTkIr0DXFCgxxK
aX8R5H5wYyZjUQeH7cvv
k1v1aF0Q8iINS81CVLXm
96k5IUtW1v8yx2ec4LFb
Jyda3B5wk44ugu5vaQHt
TeQEXEbXPD3VhodLgqiD
GoLyci7K6y4BZoALxQ8H
249tMsmfUWxV7YqFHN8B
nzXDx8JizfYYcUQJHBie
ME29OBYAvSjotZfGyuBQ
e2Wmu4uDtMXBfKfIBqLr
gSjIVwreenrWxQf80Rzi
7V7JFEMbR43psI6K4N8i
OtsOOd0PWUzomBoQZidO
iMkcCGlBYPvlgbGhtITW
4DnWF596Y60rsEai2cff
6Bz5KPgB6OFUQU6VzwiU
0faHvwFaVgNugJP6CpHt
N4yUacCC65c5peWr7pCn
BFQFRaLhHjjfeUEMhPZP
9Ey5drnttsDOzlWLTzH6
xJN9hMVWBIYE3UpMCR4O
KoHADctmqzVANw7Dy4A3
mVfuOYKv7JLBfUjlCz96
18TsX4gUNajI1Ol5T86Z
JjTGWPFlgdqJjKBMd9kq
CHmxEloHNvZ6FOf5moZA
bPwFgQD2DxE2U6js47P1
e4L1pptRiiKNBjkjQPIi
U2564afuZe7e1X16I8GD
mgKrb7Uoi04bvVKqAtZn
duuvBz1wLUiaqu99JWHI
l7G4qmZrlPTuL9HRfgaj
qmGitaN1zhwuKfM4Rdw2
jzCB2YUOk46zLYo5Kouw
gnt4KAjbOhRl9kBATWZd
E1fh0eUXmosoGy7rCLOy
ekA5eBmI5M85UHZecDCP
cdG85AXNU1gPUHIguLlu
D2C4gbQESVVdgwM6Ty0S
6SOJtOE5EYJCIpDP34XL
R02WnUYSZxwhs8KHMDVF
dWE7sZ9EqMLwy6ff82kI
71akluRSfctUNsrFT3sj
RZUojI5PMUsgdJm21311
iSrrQzKgz0lt45I8KCtL
mfCiQ8GsJy5JdPlwi6xU
MuYvLrpyNRAx9eGHShRQ
Omx9EurIhqebrNlQR7WT
nRtTKfhjJMzroqeHE3zd
VsG8DFU842syrV0PsMbw
90BY8tRLsr36KeVwI5mF
pV5JcLNRQ3WFdoTkpGiV
QwGgqsMSLcTSkE2TaG8e
hca21Mu7MtmtEbHKjxQu
vM31UGSQ63oAeIQ3hpcL
KoWMeilzsWNPX2DNk2PU
ilNYQrZ1RVZmglKBAtdb
qrKe98D54eqKaFum7r6z
oIEy2NTPFSkj8FLIpmdC
E5TNwLOahw6cCTg5vtDb
5Lq29i25gquCYGJDOWyT
bLQmKQ9chrIRoF9h1PPE
IIcEXN2nsVHAdAmUG8Ax
6yJBduWf8Zxoh8RjW80I
RnRyWErW8E7BOP5BKKqQ
EIK4ceYhoJ1ZRmN2mm7L
2teF0w70iTEp0ijG3PvN
CG3lg0uyVd2s2ZkNudZ1
VJxjVXeBHrtXP4R90qSU
jYsE3RD9zFDD4ClXlWpc
FehHuVKKkIiaTTC3PCSt
NWFOYCcXvlp0xQV7aYb7
L1flRlCAo4MJjLuFmNHd
CNvBepoLY2WbAJUOQlUV
kexQKvSs95tH9pw1qegO
0ZEmOKUSk6SBymhDlKZr
1BslJMMTd2L5aVvlXWhA
kYU1kSTwyOA78YvEjevq
a0LDcXLLKTFMsjsVMQbK
1LrPS5wlZIZNJ6Dr2K3T
8fagbW64JBTMb1rEOy72
O6TwkkvgdKp6ZcuSUlEi
2BFRKYX32IA4n0UUCLcz
N3XkJwB9DFPWLsUAMq3c
vTuI6NJ9BPfb7dbYfs55
EI4U3GIYhUpSjWLdh1kN
kgmuDZLncEq8T4yhKKiS
6czYSCiAwj7ZfNwwOaSO
3OoqkN0wvgrEqqLad3IH
x2nwXtlxK3BtDu4HRgII
pCqyv3zzDWvB3SdGX3A7
fq7X0Fc491erIzYx4at1
SD71eNAAwTMVjAWbJ4lu
BJ9u63zNsUHxZpRssHEh
tEmsEdceM9lJKwVoMeUc
ug4gxd4IsLvc52GWgYYO
QjtLlyApDsjsXXtOPRNm
YB9Jx9uB9GljyEfQBycP
XYHR5ZxDi6NNGW7NS3co
zF8Qhl1KnQNpQfa3s50Y
VgZ43MGvRQr9Zyu5GrTI
mtrwiJEE4W2DE0xdpQR3
H9ClRd0htm8KcFjnHx07
RLdE2l2qI2baLTCYQr7e
ONzOYAGqnVH5P28K6zky
szvSNIWeg9QPg6G4kzZX
EEqBD0nwHIlKcXivyfTX
EziA4LQkxnVoOaRnH3TK
aWtgXyu3D8yhaBV55Gp3
6A3SMnOlerbtgaHPLMlN
1KQ7pkhzR0K1gd7BeCNH
ZrtFBWxn8eqZEwFYgmK9
5cRmvhu9heR6hpTTS20c
ax3WxRjNmu5LjzZPrlgd
Dd4mVe36sjWfSUbiUtlg
EFpGzkGO5J6VGArOV8qk
HTISFNLXqc2DIyJYW2CP
r5JHytYVOgGg5oNaGd6Q
ZUpngiEQXYHbrRIk4JsM
GMrHFscuaJrkMPgW8tac
8kkKiuVuIcYVFqA2cUJ8
0Nchn5DkRJYnBCwzFbzR
PUne0fiwluQ5CCoKwvNw
ZP1UKkwiQF97QYEXmDR7
FWjBejiqvDdtBDSdvv11
vm3uc3gINpp2FG79gVzB
4adAdEUCwSwrnitPV5Wy
9reIDaSeT0DFpXITAETI
LesafKhEQhzzMc8QFxVe
MLD4Ux8uMA8Qp8Oq8oLj
DA4hXiUdUOF9erZtAOdr
LHZG10wdn5Qz23mXjEAy
aooi57FH92RYKA696IXO
pvWgokpZ4HU5susDdjje
2zDsAYS7JMcAnLpYg6HJ
iuxMqoYAFJgnGY4HGGvK
9bTfjYRM9UIMzuERbkA8
jHLM4W2fT8Ci5UZGdRMe
MBP1AHn4ZBUgrFfDJuGH
tvHvIvCwyEkjiVj3m6hz
uIz6EZIOSnc0aWdmh5es
Q4QNGZxUrOIgPNhoaQxr
xvpailLGarpiOR72AQ8R
riiue2sfDbVvLmbJZoy0
bHJKCFHu9an87ANQVAhc
E2z7wLXEXd3eT2K0vA55
UJcUZD6Xey7TJXjkhFcA
dWP5dBYxqUFlP819s6iO
SwfirVpSxdFsStqZwaqh
kRZraGbiK5Fr5lQRiWws
AxVPYRI9k2k1XSPma8Fg
NISFKQeNa7CgrKhhv5dA
ngPkS8hki8ZnyWeh4og4
244HTVlQ8951iVeIThyk
cmSijcTCumNgRq293AXp
82PGvoZ4oBmUfBO0J15X
3NKZfxNtbvLWxLw9bJvu
JaVZMoPmVYVhdA0tIymo
zKC2rI4GJ8XLaOLVyLD6
LJU7ktg3SCBSRMvqhLe2
HhOJRJwsFwLJKLkNB1cC
2coFCfwm6frF3vwmgF8z
C4c1bbusdZJAyxhzuuJp
9fLjXSy15XMVspczRjzf
SZ9phxm7PXXxy0z38dDM
l0dBSXItUlEWQtmS9pVY
68zR0nQTkG4wOZL02X0c
mfwjJ7NTbtfaksGqsaGd
KYXKxTEjHpawsiTtFmfY
MeyOjaitQneYtXGlpTfp
mmupJyy4WnFRFePubymK
REtgxd4hllaK3qPdgu3q
3N1JgtWLuoxsD4wE09B7
VH49t9RoqJ9k5o9V2kTM
4QYDhEBgFbcTe3mW4pNa
08B4XXPZszkSLuKVp65a
qqWiCrPNZHZDCf6Awto1
7HnWCGSAo31Ugxx5Ui6y
JfkfXHNU0sQVG5UezFzW
EWlVjFloifz1yksej1w5
VSLw87UePgd5qNwPY4tN
P9dLEN7nJlVKiUtZ0Ny8
V27rcWW2ymXyhnXXFBo3
RzApVNbxbBFRZN8JArb5
gzf45yiFI9mo29N5iZvC
z4JP2wpUqAfbcsDyQyMI
dwqArxWrdo3dRju512o3
QZd0nw0Ld0UStMMBqkYv
yrz8lqI8mH7ywUh1GT0B
XOuEoPyHjs0FvZxeyZrK
vpuy8lxXVjP5KmBt9oDp
xeS9VZE9BL0x7LboH6ri
GYLIcrp7jGoSTcHfBklI
mXGCs0fd91K7tE8Ss4ME
TKZUKVZvh5KuFoxXoUXj
4X29UylwxCZKwlnF8heE
8r1RfXVaMyVXMoe8mV8G
oVZEguIWRXmCwQWtxc9a
czk6QOudmG8UJe9IP5KF
wi8NPrmfWPj5cVtsOvQc
qJbFIMUDH1Z3Ijfj8dxd
s1jaCPWkwpcjG48d8xAc
QKchXviynnBpMk8oMT3a
vP433yGkaro7KDghkdK9
uc0akgkoDFPRmk6iAf4K
NF9wCqYSjY3dcwiVbwMC
p7MDSDKZRegotGRc4SD0
if8Bqydx6aZHINpCPDAr
DiNklYJEDojTrGwNmKtC
DkDGKjQEIQlNTTARO2pX
oA3vhKwltJhPsnJ5kRS0
6CKlv1UH05Iavjv4Vjrl
TXBdAc8q9O5k0dnnzy9j
jWkfbthD1bazSm9ZvUBf
vUeUNLaFYtPKpblvB6LC
Kpbwex4klLv9mufAq3NK
rSiu0Kzg1dDSToEaiMSS
oDADJaknYKsZZ5r7an7x
lVJEqnNRH6NnvNoiuhg0
1iOgCa2GOJN2YJtvXDMI
W4AdT6HmtuSP4j5D3Nxv
1U74WyK5PuMIo08YO0QO
qjP3dW1U8LNWwY1Twtr0
M6WHG6zez0AQg0wta5zN
oYOr7eusdOsFlvgdJAZ0
caYyNbFk8adHbYZPjUZD
y1Pkrfl0MYjbqoDYjxbw
W4xNMVfPudIPgcimpipG
iMhpNEs5QABhYmMgc3MH
JJ6NTj7XKrDJUmqmSyJJ
dDPcPw9RqVNpWqdnfl36
DXaeZ8ydnZdaenwDNjSX
ldPivHDy4B44uTBhh3vZ
E4A1LpI8oF4yi58N0VAd
Mh0SYku7yLXULYHQTup8
QWxmLvkblPNZrbKymHiB
tYEpIxPGpqZDniFM5hlL
3Tw1lJ0RDwEkgqYvcoZw
Glo2Yk60Jd87vt6kcWbi
NF8Kggtquz5ZxufGWGHu
3GUzxFqVL2lqsGoeFBrI
dui6kKNpmDofMWfenV5V
THtAmDAtOhds6TGBpAWw";

        [Fact]
        public async Task DynamoDBTruncateErrorTest()
        {           
            var config = new AmazonDynamoDBConfig
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                LogResponse = true
            };
            AmazonDynamoDBClient client = new AmazonDynamoDBClient(config);
            var tableName= await SetupTable(client);
            try
            {
                var table = Table.LoadTable(client, tableName);

                await InsertData(table, "445", _body);
                var body = await ReadData(table, "445");
                Assert.Equal(_body, body);
            }
            finally
            {
                await DeleteTable(client, tableName);
            }
        }

        private async Task<string> SetupTable(IAmazonDynamoDB dynamoDBClient)
        {
            string tableName = "aws-sdk-dotnet-truncate-test-" + DateTime.UtcNow.Ticks;

            var createTableRequest = new CreateTableRequest
            {
                TableName = tableName,
                KeySchema = new List<KeySchemaElement>
                {
                    new KeySchemaElement { AttributeName = "Id", KeyType = KeyType.HASH }
                },
                AttributeDefinitions = new List<AttributeDefinition>
                {
                    new AttributeDefinition { AttributeName = "Id", AttributeType = ScalarAttributeType.S }
                },
                BillingMode = BillingMode.PAY_PER_REQUEST,
            };

            await dynamoDBClient.CreateTableAsync(createTableRequest);

            DescribeTableResponse response = null;
            do
            {
                System.Threading.Thread.Sleep(300);
                response = await dynamoDBClient.DescribeTableAsync(tableName);
            } while (response.Table.TableStatus != TableStatus.ACTIVE);

            return tableName;
        }

        private async Task DeleteTable(IAmazonDynamoDB dynamoDBClient, string tableName)
        {
            await dynamoDBClient.DeleteTableAsync(tableName);
        }

        private static async Task InsertData(ITable table, string id, string body)
        {
            await table.PutItemAsync(new Document(new Dictionary<string, DynamoDBEntry>
            {
                ["Id"] = new Primitive(id),
                ["Body"] = new Primitive(body)
            }));
        }

        private async Task<string> ReadData(ITable table, string id)
        {
            Document doc = await table.GetItemAsync(new Primitive(id));

            var body = doc["Body"];
            return body;
        }

    }
}
