/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.QueryProtocol.Model
{
    /// <summary>
    /// Container for the parameters to the XmlLists operation. This test case serializes
    /// XML lists for the following cases for both input and output: 1. Normal XML lists.
    /// 2. Normal XML sets. 3. XML lists of lists. 4. XML lists with @xmlName on its members
    /// 5. Flattened XML lists. 6. Flattened XML lists with @xmlName. 7. Lists of structures.
    /// </summary>
    public partial class XmlListsRequest : AmazonQueryProtocolRequest
    {
    }
}
