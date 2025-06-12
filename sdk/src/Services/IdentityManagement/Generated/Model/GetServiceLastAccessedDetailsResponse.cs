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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// This is the response object from the GetServiceLastAccessedDetails operation.
    /// </summary>
    public partial class GetServiceLastAccessedDetailsResponse : AmazonWebServiceResponse
    {
        private ErrorDetails _error;
        private bool? _isTruncated;
        private DateTime? _jobCompletionDate;
        private DateTime? _jobCreationDate;
        private JobStatusType _jobStatus;
        private AccessAdvisorUsageGranularityType _jobType;
        private string _marker;
        private List<ServiceLastAccessed> _servicesLastAccessed = AWSConfigs.InitializeCollections ? new List<ServiceLastAccessed>() : null;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// An object that contains details about the reason the operation failed.
        /// </para>
        /// </summary>
        public ErrorDetails Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// A flag that indicates whether there are more items to return. If your results were
        /// truncated, you can make a subsequent pagination request using the <c>Marker</c> request
        /// parameter to retrieve more items. Note that IAM might return fewer than the <c>MaxItems</c>
        /// number of results even when there are more results available. We recommend that you
        /// check <c>IsTruncated</c> after every call to ensure that you receive all your results.
        /// </para>
        /// </summary>
        public bool? IsTruncated
        {
            get { return this._isTruncated; }
            set { this._isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this._isTruncated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobCompletionDate. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the generated report job was completed or failed.
        /// </para>
        ///  
        /// <para>
        /// This field is null if the job is still in progress, as indicated by a job status value
        /// of <c>IN_PROGRESS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? JobCompletionDate
        {
            get { return this._jobCompletionDate; }
            set { this._jobCompletionDate = value; }
        }

        // Check to see if JobCompletionDate property is set
        internal bool IsSetJobCompletionDate()
        {
            return this._jobCompletionDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobCreationDate. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the report job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? JobCreationDate
        {
            get { return this._jobCreationDate; }
            set { this._jobCreationDate = value; }
        }

        // Check to see if JobCreationDate property is set
        internal bool IsSetJobCreationDate()
        {
            return this._jobCreationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The status of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobStatusType JobStatus
        {
            get { return this._jobStatus; }
            set { this._jobStatus = value; }
        }

        // Check to see if JobStatus property is set
        internal bool IsSetJobStatus()
        {
            return this._jobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        /// The type of job. Service jobs return information about when each service was last
        /// accessed. Action jobs also include information about when tracked actions within the
        /// service were last accessed.
        /// </para>
        /// </summary>
        public AccessAdvisorUsageGranularityType JobType
        {
            get { return this._jobType; }
            set { this._jobType = value; }
        }

        // Check to see if JobType property is set
        internal bool IsSetJobType()
        {
            return this._jobType != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// When <c>IsTruncated</c> is <c>true</c>, this element is present and contains the value
        /// to use for the <c>Marker</c> parameter in a subsequent pagination request.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property ServicesLastAccessed. 
        /// <para>
        ///  A <c>ServiceLastAccessed</c> object that contains details about the most recent attempt
        /// to access the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ServiceLastAccessed> ServicesLastAccessed
        {
            get { return this._servicesLastAccessed; }
            set { this._servicesLastAccessed = value; }
        }

        // Check to see if ServicesLastAccessed property is set
        internal bool IsSetServicesLastAccessed()
        {
            return this._servicesLastAccessed != null && (this._servicesLastAccessed.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}