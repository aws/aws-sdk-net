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
 * Do not modify this file. This file is generated from the echo-service-2020-07-02.normal.json service model.
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
namespace Amazon.Echo.Model
{
    /// <summary>
    /// This is the response object from the EchoOperation operation.
    /// </summary>
    public partial class EchoOperationResponse : AmazonWebServiceResponse
    {
        private MemoryStream _blobMember;
        private bool? _booleanMember;
        private ComplexStructure _complexStructMember;
        private double? _doubleMember;
        private float? _floatMember;
        private int? _integerMember;
        private List<ComplexStructure> _listOfComplexObjectMember = AWSConfigs.InitializeCollections ? new List<ComplexStructure>() : null;
        private List<string> _listOfStringsMember = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private long? _longMember;
        private Dictionary<string, string> _mapOfStringToStringMember = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _stringMember;
        private DateTime? _timestampMember;

        /// <summary>
        /// Gets and sets the property BlobMember.
        /// </summary>
        public MemoryStream BlobMember
        {
            get { return this._blobMember; }
            set { this._blobMember = value; }
        }

        // Check to see if BlobMember property is set
        internal bool IsSetBlobMember()
        {
            return this._blobMember != null;
        }

        /// <summary>
        /// Gets and sets the property BooleanMember.
        /// </summary>
        public bool? BooleanMember
        {
            get { return this._booleanMember; }
            set { this._booleanMember = value; }
        }

        // Check to see if BooleanMember property is set
        internal bool IsSetBooleanMember()
        {
            return this._booleanMember.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ComplexStructMember.
        /// </summary>
        public ComplexStructure ComplexStructMember
        {
            get { return this._complexStructMember; }
            set { this._complexStructMember = value; }
        }

        // Check to see if ComplexStructMember property is set
        internal bool IsSetComplexStructMember()
        {
            return this._complexStructMember != null;
        }

        /// <summary>
        /// Gets and sets the property DoubleMember.
        /// </summary>
        public double? DoubleMember
        {
            get { return this._doubleMember; }
            set { this._doubleMember = value; }
        }

        // Check to see if DoubleMember property is set
        internal bool IsSetDoubleMember()
        {
            return this._doubleMember.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FloatMember.
        /// </summary>
        public float? FloatMember
        {
            get { return this._floatMember; }
            set { this._floatMember = value; }
        }

        // Check to see if FloatMember property is set
        internal bool IsSetFloatMember()
        {
            return this._floatMember.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntegerMember.
        /// </summary>
        public int? IntegerMember
        {
            get { return this._integerMember; }
            set { this._integerMember = value; }
        }

        // Check to see if IntegerMember property is set
        internal bool IsSetIntegerMember()
        {
            return this._integerMember.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ListOfComplexObjectMember.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ComplexStructure> ListOfComplexObjectMember
        {
            get { return this._listOfComplexObjectMember; }
            set { this._listOfComplexObjectMember = value; }
        }

        // Check to see if ListOfComplexObjectMember property is set
        internal bool IsSetListOfComplexObjectMember()
        {
            return this._listOfComplexObjectMember != null && (this._listOfComplexObjectMember.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ListOfStringsMember.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ListOfStringsMember
        {
            get { return this._listOfStringsMember; }
            set { this._listOfStringsMember = value; }
        }

        // Check to see if ListOfStringsMember property is set
        internal bool IsSetListOfStringsMember()
        {
            return this._listOfStringsMember != null && (this._listOfStringsMember.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LongMember.
        /// </summary>
        public long? LongMember
        {
            get { return this._longMember; }
            set { this._longMember = value; }
        }

        // Check to see if LongMember property is set
        internal bool IsSetLongMember()
        {
            return this._longMember.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MapOfStringToStringMember.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> MapOfStringToStringMember
        {
            get { return this._mapOfStringToStringMember; }
            set { this._mapOfStringToStringMember = value; }
        }

        // Check to see if MapOfStringToStringMember property is set
        internal bool IsSetMapOfStringToStringMember()
        {
            return this._mapOfStringToStringMember != null && (this._mapOfStringToStringMember.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StringMember.
        /// </summary>
        public string StringMember
        {
            get { return this._stringMember; }
            set { this._stringMember = value; }
        }

        // Check to see if StringMember property is set
        internal bool IsSetStringMember()
        {
            return this._stringMember != null;
        }

        /// <summary>
        /// Gets and sets the property TimestampMember.
        /// </summary>
        public DateTime? TimestampMember
        {
            get { return this._timestampMember; }
            set { this._timestampMember = value; }
        }

        // Check to see if TimestampMember property is set
        internal bool IsSetTimestampMember()
        {
            return this._timestampMember.HasValue; 
        }

    }
}