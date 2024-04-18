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

namespace Amazon.EC2Protocol.Model
{
    /// <summary>
    /// This is the response object from the XmlIntEnums operation.
    /// </summary>
    public partial class XmlIntEnumsResponse : AmazonWebServiceResponse
    {
        private int? _intEnum1;
        private int? _intEnum2;
        private int? _intEnum3;
        private List<int> _intEnumList = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private Dictionary<string, int> _intEnumMap = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;
        private List<int> _intEnumSet = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Gets and sets the property IntEnum1.
        /// </summary>
        public int IntEnum1
        {
            get { return this._intEnum1.GetValueOrDefault(); }
            set { this._intEnum1 = value; }
        }

        // Check to see if IntEnum1 property is set
        internal bool IsSetIntEnum1()
        {
            return this._intEnum1.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntEnum2.
        /// </summary>
        public int IntEnum2
        {
            get { return this._intEnum2.GetValueOrDefault(); }
            set { this._intEnum2 = value; }
        }

        // Check to see if IntEnum2 property is set
        internal bool IsSetIntEnum2()
        {
            return this._intEnum2.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntEnum3.
        /// </summary>
        public int IntEnum3
        {
            get { return this._intEnum3.GetValueOrDefault(); }
            set { this._intEnum3 = value; }
        }

        // Check to see if IntEnum3 property is set
        internal bool IsSetIntEnum3()
        {
            return this._intEnum3.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntEnumList.
        /// </summary>
        public List<int> IntEnumList
        {
            get { return this._intEnumList; }
            set { this._intEnumList = value; }
        }

        // Check to see if IntEnumList property is set
        internal bool IsSetIntEnumList()
        {
            return this._intEnumList != null && (this._intEnumList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IntEnumMap.
        /// </summary>
        public Dictionary<string, int> IntEnumMap
        {
            get { return this._intEnumMap; }
            set { this._intEnumMap = value; }
        }

        // Check to see if IntEnumMap property is set
        internal bool IsSetIntEnumMap()
        {
            return this._intEnumMap != null && (this._intEnumMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IntEnumSet.
        /// </summary>
        public List<int> IntEnumSet
        {
            get { return this._intEnumSet; }
            set { this._intEnumSet = value; }
        }

        // Check to see if IntEnumSet property is set
        internal bool IsSetIntEnumSet()
        {
            return this._intEnumSet != null && (this._intEnumSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}