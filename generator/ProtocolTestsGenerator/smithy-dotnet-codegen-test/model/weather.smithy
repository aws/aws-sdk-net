// $version: "1.0"
//
// namespace example.weather.simple
//
// service Weather {
//    version: "2006-03-01",
//    operations: [GetCurrentTemp]
// }
//
// @readonly
// @http(method: "GET", uri: "/?format", code: 200)
// operation GetCurrentTemp {
//    input: GetCurrentTempInput,
//    output: GetCurrentTempOutput
// }
//
// structure GetCurrentTempInput {
//    @httpQuery("/?format")
//    @required
//    format: String
// }
//
// structure GetCurrentTempOutput {
//    @required
//    temp: String
// }
