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
    /// Contains summary information about a data transformation profile. To retrieve profile
    /// content, call <c>GetDataTransformationProfile</c>.
    /// </summary>
    public partial class DataTransformationProfileSummary
    {
        private DateTime? _lastUpdatedAt;
        private string _profileDescription;
        private string _profileId;
        private string _profileName;
        private SourceFormat _sourceFormat;
        private TargetFormat _targetFormat;
        private int? _version;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp when the profile was last updated.
        /// </para>
        /// </summary>
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
        /// A description of the profile's purpose.
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
        /// The source data format that this profile converts from.
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
        /// The latest version number of the profile.
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