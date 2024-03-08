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
    /// This is the response object from the OperationWithDefaults operation.
    /// </summary>
    public partial class OperationWithDefaultsResponse : AmazonWebServiceResponse
    {
        private MemoryStream _defaultBlob;
        private bool? _defaultBoolean;
        private int? _defaultByte;
        private Amazon.Runtime.Documents.Document _defaultDocumentBoolean;
        private Amazon.Runtime.Documents.Document _defaultDocumentList;
        private Amazon.Runtime.Documents.Document _defaultDocumentMap;
        private Amazon.Runtime.Documents.Document _defaultDocumentString;
        private double? _defaultDouble;
        private TestEnum _defaultEnum;
        private float? _defaultFloat;
        private int? _defaultInteger;
        private int? _defaultIntEnum;
        private List<string> _defaultList = new List<string>();
        private long? _defaultLong;
        private Dictionary<string, string> _defaultMap = new Dictionary<string, string>();
        private Amazon.Runtime.Documents.Document _defaultNullDocument;
        private int? _defaultShort;
        private string _defaultString;
        private DateTime? _defaultTimestamp;
        private MemoryStream _emptyBlob;
        private string _emptyString;
        private bool? _falseBoolean;
        private int? _zeroByte;
        private double? _zeroDouble;
        private float? _zeroFloat;
        private int? _zeroInteger;
        private long? _zeroLong;
        private int? _zeroShort;

        /// <summary>
        /// Gets and sets the property DefaultBlob.
        /// </summary>
        public MemoryStream DefaultBlob
        {
            get { return this._defaultBlob; }
            set { this._defaultBlob = value; }
        }

        // Check to see if DefaultBlob property is set
        internal bool IsSetDefaultBlob()
        {
            return this._defaultBlob != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultBoolean.
        /// </summary>
        public bool DefaultBoolean
        {
            get { return this._defaultBoolean.GetValueOrDefault(); }
            set { this._defaultBoolean = value; }
        }

        // Check to see if DefaultBoolean property is set
        internal bool IsSetDefaultBoolean()
        {
            return this._defaultBoolean.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultByte.
        /// </summary>
        public int DefaultByte
        {
            get { return this._defaultByte.GetValueOrDefault(); }
            set { this._defaultByte = value; }
        }

        // Check to see if DefaultByte property is set
        internal bool IsSetDefaultByte()
        {
            return this._defaultByte.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultDocumentBoolean.
        /// </summary>
        public Amazon.Runtime.Documents.Document DefaultDocumentBoolean
        {
            get { return this._defaultDocumentBoolean; }
            set { this._defaultDocumentBoolean = value; }
        }

        // Check to see if DefaultDocumentBoolean property is set
        internal bool IsSetDefaultDocumentBoolean()
        {
            return !this._defaultDocumentBoolean.IsNull();
        }

        /// <summary>
        /// Gets and sets the property DefaultDocumentList.
        /// </summary>
        public Amazon.Runtime.Documents.Document DefaultDocumentList
        {
            get { return this._defaultDocumentList; }
            set { this._defaultDocumentList = value; }
        }

        // Check to see if DefaultDocumentList property is set
        internal bool IsSetDefaultDocumentList()
        {
            return !this._defaultDocumentList.IsNull();
        }

        /// <summary>
        /// Gets and sets the property DefaultDocumentMap.
        /// </summary>
        public Amazon.Runtime.Documents.Document DefaultDocumentMap
        {
            get { return this._defaultDocumentMap; }
            set { this._defaultDocumentMap = value; }
        }

        // Check to see if DefaultDocumentMap property is set
        internal bool IsSetDefaultDocumentMap()
        {
            return !this._defaultDocumentMap.IsNull();
        }

        /// <summary>
        /// Gets and sets the property DefaultDocumentString.
        /// </summary>
        public Amazon.Runtime.Documents.Document DefaultDocumentString
        {
            get { return this._defaultDocumentString; }
            set { this._defaultDocumentString = value; }
        }

        // Check to see if DefaultDocumentString property is set
        internal bool IsSetDefaultDocumentString()
        {
            return !this._defaultDocumentString.IsNull();
        }

        /// <summary>
        /// Gets and sets the property DefaultDouble.
        /// </summary>
        public double DefaultDouble
        {
            get { return this._defaultDouble.GetValueOrDefault(); }
            set { this._defaultDouble = value; }
        }

        // Check to see if DefaultDouble property is set
        internal bool IsSetDefaultDouble()
        {
            return this._defaultDouble.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultEnum.
        /// </summary>
        public TestEnum DefaultEnum
        {
            get { return this._defaultEnum; }
            set { this._defaultEnum = value; }
        }

        // Check to see if DefaultEnum property is set
        internal bool IsSetDefaultEnum()
        {
            return this._defaultEnum != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultFloat.
        /// </summary>
        public float DefaultFloat
        {
            get { return this._defaultFloat.GetValueOrDefault(); }
            set { this._defaultFloat = value; }
        }

        // Check to see if DefaultFloat property is set
        internal bool IsSetDefaultFloat()
        {
            return this._defaultFloat.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultInteger.
        /// </summary>
        public int DefaultInteger
        {
            get { return this._defaultInteger.GetValueOrDefault(); }
            set { this._defaultInteger = value; }
        }

        // Check to see if DefaultInteger property is set
        internal bool IsSetDefaultInteger()
        {
            return this._defaultInteger.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultIntEnum.
        /// </summary>
        public int DefaultIntEnum
        {
            get { return this._defaultIntEnum.GetValueOrDefault(); }
            set { this._defaultIntEnum = value; }
        }

        // Check to see if DefaultIntEnum property is set
        internal bool IsSetDefaultIntEnum()
        {
            return this._defaultIntEnum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultList.
        /// </summary>
        public List<string> DefaultList
        {
            get { return this._defaultList; }
            set { this._defaultList = value; }
        }

        // Check to see if DefaultList property is set
        internal bool IsSetDefaultList()
        {
            return this._defaultList != null && this._defaultList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DefaultLong.
        /// </summary>
        public long DefaultLong
        {
            get { return this._defaultLong.GetValueOrDefault(); }
            set { this._defaultLong = value; }
        }

        // Check to see if DefaultLong property is set
        internal bool IsSetDefaultLong()
        {
            return this._defaultLong.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultMap.
        /// </summary>
        public Dictionary<string, string> DefaultMap
        {
            get { return this._defaultMap; }
            set { this._defaultMap = value; }
        }

        // Check to see if DefaultMap property is set
        internal bool IsSetDefaultMap()
        {
            return this._defaultMap != null && this._defaultMap.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DefaultNullDocument.
        /// </summary>
        public Amazon.Runtime.Documents.Document DefaultNullDocument
        {
            get { return this._defaultNullDocument; }
            set { this._defaultNullDocument = value; }
        }

        // Check to see if DefaultNullDocument property is set
        internal bool IsSetDefaultNullDocument()
        {
            return !this._defaultNullDocument.IsNull();
        }

        /// <summary>
        /// Gets and sets the property DefaultShort.
        /// </summary>
        public int DefaultShort
        {
            get { return this._defaultShort.GetValueOrDefault(); }
            set { this._defaultShort = value; }
        }

        // Check to see if DefaultShort property is set
        internal bool IsSetDefaultShort()
        {
            return this._defaultShort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultString.
        /// </summary>
        public string DefaultString
        {
            get { return this._defaultString; }
            set { this._defaultString = value; }
        }

        // Check to see if DefaultString property is set
        internal bool IsSetDefaultString()
        {
            return this._defaultString != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultTimestamp.
        /// </summary>
        public DateTime DefaultTimestamp
        {
            get { return this._defaultTimestamp.GetValueOrDefault(); }
            set { this._defaultTimestamp = value; }
        }

        // Check to see if DefaultTimestamp property is set
        internal bool IsSetDefaultTimestamp()
        {
            return this._defaultTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EmptyBlob.
        /// </summary>
        public MemoryStream EmptyBlob
        {
            get { return this._emptyBlob; }
            set { this._emptyBlob = value; }
        }

        // Check to see if EmptyBlob property is set
        internal bool IsSetEmptyBlob()
        {
            return this._emptyBlob != null;
        }

        /// <summary>
        /// Gets and sets the property EmptyString.
        /// </summary>
        public string EmptyString
        {
            get { return this._emptyString; }
            set { this._emptyString = value; }
        }

        // Check to see if EmptyString property is set
        internal bool IsSetEmptyString()
        {
            return this._emptyString != null;
        }

        /// <summary>
        /// Gets and sets the property FalseBoolean.
        /// </summary>
        public bool FalseBoolean
        {
            get { return this._falseBoolean.GetValueOrDefault(); }
            set { this._falseBoolean = value; }
        }

        // Check to see if FalseBoolean property is set
        internal bool IsSetFalseBoolean()
        {
            return this._falseBoolean.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ZeroByte.
        /// </summary>
        public int ZeroByte
        {
            get { return this._zeroByte.GetValueOrDefault(); }
            set { this._zeroByte = value; }
        }

        // Check to see if ZeroByte property is set
        internal bool IsSetZeroByte()
        {
            return this._zeroByte.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ZeroDouble.
        /// </summary>
        public double ZeroDouble
        {
            get { return this._zeroDouble.GetValueOrDefault(); }
            set { this._zeroDouble = value; }
        }

        // Check to see if ZeroDouble property is set
        internal bool IsSetZeroDouble()
        {
            return this._zeroDouble.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ZeroFloat.
        /// </summary>
        public float ZeroFloat
        {
            get { return this._zeroFloat.GetValueOrDefault(); }
            set { this._zeroFloat = value; }
        }

        // Check to see if ZeroFloat property is set
        internal bool IsSetZeroFloat()
        {
            return this._zeroFloat.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ZeroInteger.
        /// </summary>
        public int ZeroInteger
        {
            get { return this._zeroInteger.GetValueOrDefault(); }
            set { this._zeroInteger = value; }
        }

        // Check to see if ZeroInteger property is set
        internal bool IsSetZeroInteger()
        {
            return this._zeroInteger.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ZeroLong.
        /// </summary>
        public long ZeroLong
        {
            get { return this._zeroLong.GetValueOrDefault(); }
            set { this._zeroLong = value; }
        }

        // Check to see if ZeroLong property is set
        internal bool IsSetZeroLong()
        {
            return this._zeroLong.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ZeroShort.
        /// </summary>
        public int ZeroShort
        {
            get { return this._zeroShort.GetValueOrDefault(); }
            set { this._zeroShort = value; }
        }

        // Check to see if ZeroShort property is set
        internal bool IsSetZeroShort()
        {
            return this._zeroShort.HasValue; 
        }

    }
}