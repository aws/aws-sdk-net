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
 * Do not modify this file. This file is generated from the query-protocol-2020-01-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QueryProtocol.Model
{
    /// <summary>
    /// Container for the parameters to the QueryLists operation.
    /// This test serializes simple and complex lists.
    /// </summary>
    public partial class QueryListsRequest : AmazonQueryProtocolRequest
    {
        private List<GreetingStruct> _complexListArg = new List<GreetingStruct>();
        private List<string> _flattenedListArg = new List<string>();
        private List<string> _flattenedListArgWithXmlName = new List<string>();
        private List<string> _listArg = new List<string>();
        private List<string> _listArgWithXmlNameMember = new List<string>();
        private NestedStructWithList _nestedWithList;

        /// <summary>
        /// Gets and sets the property ComplexListArg.
        /// </summary>
        public List<GreetingStruct> ComplexListArg
        {
            get { return this._complexListArg; }
            set { this._complexListArg = value; }
        }

        // Check to see if ComplexListArg property is set
        internal bool IsSetComplexListArg()
        {
            return this._complexListArg != null && this._complexListArg.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FlattenedListArg.
        /// </summary>
        public List<string> FlattenedListArg
        {
            get { return this._flattenedListArg; }
            set { this._flattenedListArg = value; }
        }

        // Check to see if FlattenedListArg property is set
        internal bool IsSetFlattenedListArg()
        {
            return this._flattenedListArg != null && this._flattenedListArg.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FlattenedListArgWithXmlName.
        /// </summary>
        public List<string> FlattenedListArgWithXmlName
        {
            get { return this._flattenedListArgWithXmlName; }
            set { this._flattenedListArgWithXmlName = value; }
        }

        // Check to see if FlattenedListArgWithXmlName property is set
        internal bool IsSetFlattenedListArgWithXmlName()
        {
            return this._flattenedListArgWithXmlName != null && this._flattenedListArgWithXmlName.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ListArg.
        /// </summary>
        public List<string> ListArg
        {
            get { return this._listArg; }
            set { this._listArg = value; }
        }

        // Check to see if ListArg property is set
        internal bool IsSetListArg()
        {
            return this._listArg != null && this._listArg.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ListArgWithXmlNameMember.
        /// </summary>
        public List<string> ListArgWithXmlNameMember
        {
            get { return this._listArgWithXmlNameMember; }
            set { this._listArgWithXmlNameMember = value; }
        }

        // Check to see if ListArgWithXmlNameMember property is set
        internal bool IsSetListArgWithXmlNameMember()
        {
            return this._listArgWithXmlNameMember != null && this._listArgWithXmlNameMember.Count > 0; 
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