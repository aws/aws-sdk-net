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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the StartImport operation.
    /// Starts an import of logged trail events from a source S3 bucket to a destination
    /// event data store. By default, CloudTrail only imports events contained in the S3 bucket's
    /// <code>CloudTrail</code> prefix and the prefixes inside the <code>CloudTrail</code>
    /// prefix, and does not check prefixes for other Amazon Web Services services. If you
    /// want to import CloudTrail events contained in another prefix, you must include the
    /// prefix in the <code>S3LocationUri</code>. For more considerations about importing
    /// trail events, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-copy-trail-to-lake.html#cloudtrail-trail-copy-considerations">Considerations</a>.
    /// 
    /// 
    ///  
    /// <para>
    ///  When you start a new import, the <code>Destinations</code> and <code>ImportSource</code>
    /// parameters are required. Before starting a new import, disable any access control
    /// lists (ACLs) attached to the source S3 bucket. For more information about disabling
    /// ACLs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html">Controlling
    /// ownership of objects and disabling ACLs for your bucket</a>. 
    /// </para>
    ///  
    /// <para>
    ///  When you retry an import, the <code>ImportID</code> parameter is required. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  If the destination event data store is for an organization, you must use the management
    /// account to import trail events. You cannot use the delegated administrator account
    /// for the organization. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class StartImportRequest : AmazonCloudTrailRequest
    {
        private List<string> _destinations = new List<string>();
        private DateTime? _endEventTime;
        private string _importId;
        private ImportSource _importSource;
        private DateTime? _startEventTime;

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        ///  The ARN of the destination event data store. Use this parameter for a new import.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && this._destinations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EndEventTime. 
        /// <para>
        ///  Use with <code>StartEventTime</code> to bound a <code>StartImport</code> request,
        /// and limit imported trail events to only those events logged within a specified time
        /// period. When you specify a time range, CloudTrail checks the prefix and log file names
        /// to verify the names contain a date between the specified <code>StartEventTime</code>
        /// and <code>EndEventTime</code> before attempting to import events. 
        /// </para>
        /// </summary>
        public DateTime EndEventTime
        {
            get { return this._endEventTime.GetValueOrDefault(); }
            set { this._endEventTime = value; }
        }

        // Check to see if EndEventTime property is set
        internal bool IsSetEndEventTime()
        {
            return this._endEventTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImportId. 
        /// <para>
        ///  The ID of the import. Use this parameter when you are retrying an import. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ImportId
        {
            get { return this._importId; }
            set { this._importId = value; }
        }

        // Check to see if ImportId property is set
        internal bool IsSetImportId()
        {
            return this._importId != null;
        }

        /// <summary>
        /// Gets and sets the property ImportSource. 
        /// <para>
        ///  The source S3 bucket for the import. Use this parameter for a new import. 
        /// </para>
        /// </summary>
        public ImportSource ImportSource
        {
            get { return this._importSource; }
            set { this._importSource = value; }
        }

        // Check to see if ImportSource property is set
        internal bool IsSetImportSource()
        {
            return this._importSource != null;
        }

        /// <summary>
        /// Gets and sets the property StartEventTime. 
        /// <para>
        ///  Use with <code>EndEventTime</code> to bound a <code>StartImport</code> request, and
        /// limit imported trail events to only those events logged within a specified time period.
        /// When you specify a time range, CloudTrail checks the prefix and log file names to
        /// verify the names contain a date between the specified <code>StartEventTime</code>
        /// and <code>EndEventTime</code> before attempting to import events. 
        /// </para>
        /// </summary>
        public DateTime StartEventTime
        {
            get { return this._startEventTime.GetValueOrDefault(); }
            set { this._startEventTime = value; }
        }

        // Check to see if StartEventTime property is set
        internal bool IsSetStartEventTime()
        {
            return this._startEventTime.HasValue; 
        }

    }
}