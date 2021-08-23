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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// This is the response object from the CreateReportPlan operation.
    /// </summary>
    public partial class CreateReportPlanResponse : AmazonWebServiceResponse
    {
        private string _reportPlanArn;
        private string _reportPlanName;

        /// <summary>
        /// Gets and sets the property ReportPlanArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a resource. The format of the
        /// ARN depends on the resource type.
        /// </para>
        /// </summary>
        public string ReportPlanArn
        {
            get { return this._reportPlanArn; }
            set { this._reportPlanArn = value; }
        }

        // Check to see if ReportPlanArn property is set
        internal bool IsSetReportPlanArn()
        {
            return this._reportPlanArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReportPlanName. 
        /// <para>
        /// The unique name of the report plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ReportPlanName
        {
            get { return this._reportPlanName; }
            set { this._reportPlanName = value; }
        }

        // Check to see if ReportPlanName property is set
        internal bool IsSetReportPlanName()
        {
            return this._reportPlanName != null;
        }

    }
}