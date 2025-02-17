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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CancelDeclarativePoliciesReport operation.
    /// Cancels the generation of an account status report.
    /// 
    ///  
    /// <para>
    /// You can only cancel a report while it has the <c>running</c> status. Reports with
    /// other statuses (<c>complete</c>, <c>cancelled</c>, or <c>error</c>) can't be canceled.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_declarative_status-report.html">Generating
    /// the account status report for declarative policies</a> in the <i>Amazon Web Services
    /// Organizations User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CancelDeclarativePoliciesReportRequest : AmazonEC2Request
    {
        private string _reportId;

        /// <summary>
        /// Gets and sets the property ReportId. 
        /// <para>
        /// The ID of the report.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReportId
        {
            get { return this._reportId; }
            set { this._reportId = value; }
        }

        // Check to see if ReportId property is set
        internal bool IsSetReportId()
        {
            return this._reportId != null;
        }

    }
}