/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        private string _marker;
        private List<ServiceLastAccessed> _servicesLastAccessed = new List<ServiceLastAccessed>();

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
        /// truncated, you can make a subsequent pagination request using the <code>Marker</code>
        /// request parameter to retrieve more items. Note that IAM might return fewer than the
        /// <code>MaxItems</code> number of results even when there are more results available.
        /// We recommend that you check <code>IsTruncated</code> after every call to ensure that
        /// you receive all your results.
        /// </para>
        /// </summary>
        public bool IsTruncated
        {
            get { return this._isTruncated.GetValueOrDefault(); }
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
        /// This field is null if the job is still in progress, as indicated by a <code>JobStatus</code>
        /// value of <code>IN_PROGRESS</code>.
        /// </para>
        /// </summary>
        public DateTime JobCompletionDate
        {
            get { return this._jobCompletionDate.GetValueOrDefault(); }
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
        public DateTime JobCreationDate
        {
            get { return this._jobCreationDate.GetValueOrDefault(); }
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
        /// Gets and sets the property Marker. 
        /// <para>
        /// When <code>IsTruncated</code> is <code>true</code>, this element is present and contains
        /// the value to use for the <code>Marker</code> parameter in a subsequent pagination
        /// request.
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
        ///  A <code>ServiceLastAccessed</code> object that contains details about the most recent
        /// attempt to access the service.
        /// </para>
        /// </summary>
        public List<ServiceLastAccessed> ServicesLastAccessed
        {
            get { return this._servicesLastAccessed; }
            set { this._servicesLastAccessed = value; }
        }

        // Check to see if ServicesLastAccessed property is set
        internal bool IsSetServicesLastAccessed()
        {
            return this._servicesLastAccessed != null && this._servicesLastAccessed.Count > 0; 
        }

    }
}