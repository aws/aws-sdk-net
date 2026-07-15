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
    /// Container for the parameters to the PublishDataTransformationProfile operation.
    /// Promotes the current DRAFT version of a data transformation profile to a new immutable
    /// published version. Also supports rollback by publishing from a previously published
    /// version.
    /// </summary>
    public partial class PublishDataTransformationProfileRequest : AmazonHealthLakeRequest
    {
        private string _changeDescription;
        private int? _fromExistingVersion;
        private string _profileId;
        private SourceFormat _sourceFormat;

        /// <summary>
        /// Gets and sets the property ChangeDescription. 
        /// <para>
        /// A description of what changed or why this version is being published.
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
        /// Gets and sets the property FromExistingVersion. 
        /// <para>
        /// The version number of a previously published version to republish as the new latest
        /// version. Use this parameter for rollback scenarios. If you omit this parameter, the
        /// service publishes the current DRAFT version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=99)]
        public int? FromExistingVersion
        {
            get { return this._fromExistingVersion; }
            set { this._fromExistingVersion = value; }
        }

        // Check to see if FromExistingVersion property is set
        internal bool IsSetFromExistingVersion()
        {
            return this._fromExistingVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier of the profile to publish.
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

    }
}