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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Container for the parameters to the BatchUpdateRecommendationStatus operation.
    /// Enables you to include or exclude one or more operational recommendations.
    /// </summary>
    public partial class BatchUpdateRecommendationStatusRequest : AmazonResilienceHubRequest
    {
        private string _appArn;
        private List<UpdateRecommendationStatusRequestEntry> _requestEntries = new List<UpdateRecommendationStatusRequestEntry>();

        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the Resilience Hub application. The format for this
        /// ARN is: arn:<code>partition</code>:resiliencehub:<code>region</code>:<code>account</code>:app/<code>app-id</code>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>AWS General Reference</i> guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppArn
        {
            get { return this._appArn; }
            set { this._appArn = value; }
        }

        // Check to see if AppArn property is set
        internal bool IsSetAppArn()
        {
            return this._appArn != null;
        }

        /// <summary>
        /// Gets and sets the property RequestEntries. 
        /// <para>
        /// Defines the list of operational recommendations that need to be included or excluded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<UpdateRecommendationStatusRequestEntry> RequestEntries
        {
            get { return this._requestEntries; }
            set { this._requestEntries = value; }
        }

        // Check to see if RequestEntries property is set
        internal bool IsSetRequestEntries()
        {
            return this._requestEntries != null && this._requestEntries.Count > 0; 
        }

    }
}