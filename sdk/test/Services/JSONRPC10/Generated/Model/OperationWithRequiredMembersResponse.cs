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
 * Do not modify this file. This file is generated from the json-rpc-10-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.JSONRPC10.Model
{
    /// <summary>
    /// This is the response object from the OperationWithRequiredMembers operation.
    /// </summary>
    public partial class OperationWithRequiredMembersResponse : AmazonWebServiceResponse
    {
        private MemoryStream _requiredBlob;
        private bool? _requiredBoolean;
        private int? _requiredByte;
        private double? _requiredDouble;
        private float? _requiredFloat;
        private int? _requiredInteger;
        private List<string> _requiredList = new List<string>();
        private long? _requiredLong;
        private Dictionary<string, string> _requiredMap = new Dictionary<string, string>();
        private int? _requiredShort;
        private string _requiredString;
        private DateTime? _requiredTimestamp;

        /// <summary>
        /// Gets and sets the property RequiredBlob.
        /// </summary>
        [AWSProperty(Required=true)]
        public MemoryStream RequiredBlob
        {
            get { return this._requiredBlob; }
            set { this._requiredBlob = value; }
        }

        // Check to see if RequiredBlob property is set
        internal bool IsSetRequiredBlob()
        {
            return this._requiredBlob != null;
        }

        /// <summary>
        /// Gets and sets the property RequiredBoolean.
        /// </summary>
        [AWSProperty(Required=true)]
        public bool RequiredBoolean
        {
            get { return this._requiredBoolean.GetValueOrDefault(); }
            set { this._requiredBoolean = value; }
        }

        // Check to see if RequiredBoolean property is set
        internal bool IsSetRequiredBoolean()
        {
            return this._requiredBoolean.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequiredByte.
        /// </summary>
        [AWSProperty(Required=true)]
        public int RequiredByte
        {
            get { return this._requiredByte.GetValueOrDefault(); }
            set { this._requiredByte = value; }
        }

        // Check to see if RequiredByte property is set
        internal bool IsSetRequiredByte()
        {
            return this._requiredByte.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequiredDouble.
        /// </summary>
        [AWSProperty(Required=true)]
        public double RequiredDouble
        {
            get { return this._requiredDouble.GetValueOrDefault(); }
            set { this._requiredDouble = value; }
        }

        // Check to see if RequiredDouble property is set
        internal bool IsSetRequiredDouble()
        {
            return this._requiredDouble.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequiredFloat.
        /// </summary>
        [AWSProperty(Required=true)]
        public float RequiredFloat
        {
            get { return this._requiredFloat.GetValueOrDefault(); }
            set { this._requiredFloat = value; }
        }

        // Check to see if RequiredFloat property is set
        internal bool IsSetRequiredFloat()
        {
            return this._requiredFloat.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequiredInteger.
        /// </summary>
        [AWSProperty(Required=true)]
        public int RequiredInteger
        {
            get { return this._requiredInteger.GetValueOrDefault(); }
            set { this._requiredInteger = value; }
        }

        // Check to see if RequiredInteger property is set
        internal bool IsSetRequiredInteger()
        {
            return this._requiredInteger.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequiredList.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> RequiredList
        {
            get { return this._requiredList; }
            set { this._requiredList = value; }
        }

        // Check to see if RequiredList property is set
        internal bool IsSetRequiredList()
        {
            return this._requiredList != null && this._requiredList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RequiredLong.
        /// </summary>
        [AWSProperty(Required=true)]
        public long RequiredLong
        {
            get { return this._requiredLong.GetValueOrDefault(); }
            set { this._requiredLong = value; }
        }

        // Check to see if RequiredLong property is set
        internal bool IsSetRequiredLong()
        {
            return this._requiredLong.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequiredMap.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> RequiredMap
        {
            get { return this._requiredMap; }
            set { this._requiredMap = value; }
        }

        // Check to see if RequiredMap property is set
        internal bool IsSetRequiredMap()
        {
            return this._requiredMap != null && this._requiredMap.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RequiredShort.
        /// </summary>
        [AWSProperty(Required=true)]
        public int RequiredShort
        {
            get { return this._requiredShort.GetValueOrDefault(); }
            set { this._requiredShort = value; }
        }

        // Check to see if RequiredShort property is set
        internal bool IsSetRequiredShort()
        {
            return this._requiredShort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequiredString.
        /// </summary>
        [AWSProperty(Required=true)]
        public string RequiredString
        {
            get { return this._requiredString; }
            set { this._requiredString = value; }
        }

        // Check to see if RequiredString property is set
        internal bool IsSetRequiredString()
        {
            return this._requiredString != null;
        }

        /// <summary>
        /// Gets and sets the property RequiredTimestamp.
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime RequiredTimestamp
        {
            get { return this._requiredTimestamp.GetValueOrDefault(); }
            set { this._requiredTimestamp = value; }
        }

        // Check to see if RequiredTimestamp property is set
        internal bool IsSetRequiredTimestamp()
        {
            return this._requiredTimestamp.HasValue; 
        }

    }
}