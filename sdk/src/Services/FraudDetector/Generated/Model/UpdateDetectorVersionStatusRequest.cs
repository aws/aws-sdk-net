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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
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
namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDetectorVersionStatus operation.
    /// Updates the detector version’s status. You can perform the following promotions or
    /// demotions using <c>UpdateDetectorVersionStatus</c>: <c>DRAFT</c> to <c>ACTIVE</c>,
    /// <c>ACTIVE</c> to <c>INACTIVE</c>, and <c>INACTIVE</c> to <c>ACTIVE</c>.
    /// </summary>
    public partial class UpdateDetectorVersionStatusRequest : AmazonFraudDetectorRequest
    {
        private string _detectorId;
        private string _detectorVersionId;
        private DetectorVersionStatus _status;

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The detector ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property DetectorVersionId. 
        /// <para>
        /// The detector version ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public string DetectorVersionId
        {
            get { return this._detectorVersionId; }
            set { this._detectorVersionId = value; }
        }

        // Check to see if DetectorVersionId property is set
        internal bool IsSetDetectorVersionId()
        {
            return this._detectorVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The new status.
        /// </para>
        ///  
        /// <para>
        /// The only supported values are <c>ACTIVE</c> and <c>INACTIVE</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DetectorVersionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}