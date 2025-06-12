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
 * Do not modify this file. This file is generated from the ec2-protocol-2020-01-08.normal.json service model.
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
namespace Amazon.EC2Protocol.Model
{
    /// <summary>
    /// Container for the parameters to the QueryLists operation.
    /// This test serializes simple and complex lists.
    /// </summary>
    public partial class QueryListsRequest : AmazonEC2ProtocolRequest
    {
        private List<GreetingStruct> _complexListArg = AWSConfigs.InitializeCollections ? new List<GreetingStruct>() : null;
        private List<string> _listArg = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _listArgWithXmlName = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _listArgWithXmlNameMember = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private NestedStructWithList _nestedWithList;

        /// <summary>
        /// Gets and sets the property ComplexListArg.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GreetingStruct> ComplexListArg
        {
            get { return this._complexListArg; }
            set { this._complexListArg = value; }
        }

        // Check to see if ComplexListArg property is set
        internal bool IsSetComplexListArg()
        {
            return this._complexListArg != null && (this._complexListArg.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ListArg.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ListArg
        {
            get { return this._listArg; }
            set { this._listArg = value; }
        }

        // Check to see if ListArg property is set
        internal bool IsSetListArg()
        {
            return this._listArg != null && (this._listArg.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ListArgWithXmlName.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ListArgWithXmlName
        {
            get { return this._listArgWithXmlName; }
            set { this._listArgWithXmlName = value; }
        }

        // Check to see if ListArgWithXmlName property is set
        internal bool IsSetListArgWithXmlName()
        {
            return this._listArgWithXmlName != null && (this._listArgWithXmlName.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ListArgWithXmlNameMember.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ListArgWithXmlNameMember
        {
            get { return this._listArgWithXmlNameMember; }
            set { this._listArgWithXmlNameMember = value; }
        }

        // Check to see if ListArgWithXmlNameMember property is set
        internal bool IsSetListArgWithXmlNameMember()
        {
            return this._listArgWithXmlNameMember != null && (this._listArgWithXmlNameMember.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NestedWithList.
        /// </summary>
        public NestedStructWithList NestedWithList
        {
            get { return this._nestedWithList; }
            set { this._nestedWithList = value; }
        }

        // Check to see if NestedWithList property is set
        internal bool IsSetNestedWithList()
        {
            return this._nestedWithList != null;
        }

    }
}