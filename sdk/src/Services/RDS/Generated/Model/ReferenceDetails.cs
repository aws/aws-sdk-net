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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// The reference details of a metric.
    /// </summary>
    public partial class ReferenceDetails
    {
        private ScalarReferenceDetails _scalarReferenceDetails;

        /// <summary>
        /// Gets and sets the property ScalarReferenceDetails. 
        /// <para>
        /// The metric reference details when the reference is a scalar.
        /// </para>
        /// </summary>
        public ScalarReferenceDetails ScalarReferenceDetails
        {
            get { return this._scalarReferenceDetails; }
            set { this._scalarReferenceDetails = value; }
        }

        // Check to see if ScalarReferenceDetails property is set
        internal bool IsSetScalarReferenceDetails()
        {
            return this._scalarReferenceDetails != null;
        }

    }
}