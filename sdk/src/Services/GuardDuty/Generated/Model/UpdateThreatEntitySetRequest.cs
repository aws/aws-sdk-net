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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateThreatEntitySet operation.
    /// Updates the threat entity set associated with the specified <c>threatEntitySetId</c>.
    /// </summary>
    public partial class UpdateThreatEntitySetRequest : AmazonGuardDutyRequest
    {
        private bool? _activate;
        private string _detectorId;
        private string _expectedBucketOwner;
        private string _location;
        private string _name;
        private string _threatEntitySetId;

        /// <summary>
        /// Gets and sets the property Activate. 
        /// <para>
        /// A boolean value that indicates whether GuardDuty is to start using this updated threat
        /// entity set. After you update an entity set, you will need to activate it again. It
        /// might take up to 15 minutes for the updated entity set to be effective.
        /// </para>
        /// </summary>
        public bool? Activate
        {
            get { return this._activate; }
            set { this._activate = value; }
        }

        // Check to see if Activate property is set
        internal bool IsSetActivate()
        {
            return this._activate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The unique ID of the GuardDuty detector associated with the threat entity set that
        /// you want to update.
        /// </para>
        ///  
        /// <para>
        /// To find the <c>detectorId</c> in the current Region, see the Settings page in the
        /// GuardDuty console, or run the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_ListDetectors.html">ListDetectors</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The Amazon Web Services account ID that owns the Amazon S3 bucket specified in the
        /// <b>location</b> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string ExpectedBucketOwner
        {
            get { return this._expectedBucketOwner; }
            set { this._expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return this._expectedBucketOwner != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The URI of the file that contains the trusted entity set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A user-friendly name to identify the trusted entity set.
        /// </para>
        ///  
        /// <para>
        /// The name of your list can include lowercase letters, uppercase letters, numbers, dash
        /// (-), and underscore (_).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ThreatEntitySetId. 
        /// <para>
        /// The ID returned by GuardDuty after updating the threat entity set resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ThreatEntitySetId
        {
            get { return this._threatEntitySetId; }
            set { this._threatEntitySetId = value; }
        }

        // Check to see if ThreatEntitySetId property is set
        internal bool IsSetThreatEntitySetId()
        {
            return this._threatEntitySetId != null;
        }

    }
}