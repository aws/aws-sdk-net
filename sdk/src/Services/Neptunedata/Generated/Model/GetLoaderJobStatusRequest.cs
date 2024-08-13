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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
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
namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// Container for the parameters to the GetLoaderJobStatus operation.
    /// Gets status information about a specified load job. Neptune keeps track of the most
    /// recent 1,024 bulk load jobs, and stores the last 10,000 error details per job.
    /// 
    ///  
    /// <para>
    /// See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/load-api-reference-status.htm">Neptune
    /// Loader Get-Status API</a> for more information.
    /// </para>
    ///  
    /// <para>
    /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
    /// the IAM user or role making the request must have a policy attached that allows the
    /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getloaderjobstatus">neptune-db:GetLoaderJobStatus</a>
    /// IAM action in that cluster..
    /// </para>
    /// </summary>
    public partial class GetLoaderJobStatusRequest : AmazonNeptunedataRequest
    {
        private bool? _details;
        private bool? _errors;
        private int? _errorsPerPage;
        private string _loadId;
        private int? _page;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// Flag indicating whether or not to include details beyond the overall status (<c>TRUE</c>
        /// or <c>FALSE</c>; the default is <c>FALSE</c>).
        /// </para>
        /// </summary>
        public bool? Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// Flag indicating whether or not to include a list of errors encountered (<c>TRUE</c>
        /// or <c>FALSE</c>; the default is <c>FALSE</c>).
        /// </para>
        ///  
        /// <para>
        /// The list of errors is paged. The <c>page</c> and <c>errorsPerPage</c> parameters allow
        /// you to page through all the errors.
        /// </para>
        /// </summary>
        public bool? Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorsPerPage. 
        /// <para>
        /// The number of errors returned in each page (a positive integer; the default is <c>10</c>).
        /// Only valid when the <c>errors</c> parameter set to <c>TRUE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? ErrorsPerPage
        {
            get { return this._errorsPerPage; }
            set { this._errorsPerPage = value; }
        }

        // Check to see if ErrorsPerPage property is set
        internal bool IsSetErrorsPerPage()
        {
            return this._errorsPerPage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoadId. 
        /// <para>
        /// The load ID of the load job to get the status of.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LoadId
        {
            get { return this._loadId; }
            set { this._loadId = value; }
        }

        // Check to see if LoadId property is set
        internal bool IsSetLoadId()
        {
            return this._loadId != null;
        }

        /// <summary>
        /// Gets and sets the property Page. 
        /// <para>
        /// The error page number (a positive integer; the default is <c>1</c>). Only valid when
        /// the <c>errors</c> parameter is set to <c>TRUE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Page
        {
            get { return this._page; }
            set { this._page = value; }
        }

        // Check to see if Page property is set
        internal bool IsSetPage()
        {
            return this._page.HasValue; 
        }

    }
}