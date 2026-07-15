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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
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
namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// The response from the <c>GetDataTransformationProfile</c> operation.
    /// </summary>
    public partial class GetDataTransformationProfileResponse : AmazonWebServiceResponse
    {
        private string _changeDescription;
        private DateTime? _lastUpdatedAt;
        private string _profileDescription;
        private string _profileId;
        private Dictionary<string, string> _profileMapping = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _profileName;
        private SourceFormat _sourceFormat;
        private TargetFormat _targetFormat;
        private int? _version;

        /// <summary>
        /// Gets and sets the property ChangeDescription. 
        /// <para>
        /// A description of what changed in this version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string ChangeDescription
        {
            get { return this._changeDescription; }
            set { this._changeDescription = value; }
        }

        // Check to see if ChangeDescription property is set
        internal bool IsSetChangeDescription()
        {
            return this._changeDescription != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp when this version was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProfileDescription. 
        /// <para>
        /// The description of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string ProfileDescription
        {
            get { return this._profileDescription; }
            set { this._profileDescription = value; }
        }

        // Check to see if ProfileDescription property is set
        internal bool IsSetProfileDescription()
        {
            return this._profileDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=32)]
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileMapping. 
        /// <para>
        /// The profile content as a map of file paths to content strings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=500)]
        public Dictionary<string, string> ProfileMapping
        {
            get { return this._profileMapping; }
            set { this._profileMapping = value; }
        }

        // Check to see if ProfileMapping property is set
        internal bool IsSetProfileMapping()
        {
            return this._profileMapping != null && (this._profileMapping.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The name of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ProfileName
        {
            get { return this._profileName; }
            set { this._profileName = value; }
        }

        // Check to see if ProfileName property is set
        internal bool IsSetProfileName()
        {
            return this._profileName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFormat. 
        /// <para>
        /// The source data format of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceFormat SourceFormat
        {
            get { return this._sourceFormat; }
            set { this._sourceFormat = value; }
        }

        // Check to see if SourceFormat property is set
        internal bool IsSetSourceFormat()
        {
            return this._sourceFormat != null;
        }

        /// <summary>
        /// Gets and sets the property TargetFormat. 
        /// <para>
        /// The target output format of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TargetFormat TargetFormat
        {
            get { return this._targetFormat; }
            set { this._targetFormat = value; }
        }

        // Check to see if TargetFormat property is set
        internal bool IsSetTargetFormat()
        {
            return this._targetFormat != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the retrieved profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=99)]
        public int? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}