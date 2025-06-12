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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeRegistrationFieldValues operation.
    /// Retrieves the specified registration field values.
    /// </summary>
    public partial class DescribeRegistrationFieldValuesRequest : AmazonPinpointSMSVoiceV2Request
    {
        private List<string> _fieldPaths = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;
        private string _registrationId;
        private string _sectionPath;
        private long? _versionNumber;

        /// <summary>
        /// Gets and sets the property FieldPaths. 
        /// <para>
        /// An array of paths to the registration form field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> FieldPaths
        {
            get { return this._fieldPaths; }
            set { this._fieldPaths = value; }
        }

        // Check to see if FieldPaths property is set
        internal bool IsSetFieldPaths()
        {
            return this._fieldPaths != null && (this._fieldPaths.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per each request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to be used for the next set of paginated results. You don't need to supply
        /// a value for this field in the initial request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationId. 
        /// <para>
        /// The unique identifier for the registration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string RegistrationId
        {
            get { return this._registrationId; }
            set { this._registrationId = value; }
        }

        // Check to see if RegistrationId property is set
        internal bool IsSetRegistrationId()
        {
            return this._registrationId != null;
        }

        /// <summary>
        /// Gets and sets the property SectionPath. 
        /// <para>
        /// The path to the section of the registration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string SectionPath
        {
            get { return this._sectionPath; }
            set { this._sectionPath = value; }
        }

        // Check to see if SectionPath property is set
        internal bool IsSetSectionPath()
        {
            return this._sectionPath != null;
        }

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version number of the registration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
        public long? VersionNumber
        {
            get { return this._versionNumber; }
            set { this._versionNumber = value; }
        }

        // Check to see if VersionNumber property is set
        internal bool IsSetVersionNumber()
        {
            return this._versionNumber.HasValue; 
        }

    }
}