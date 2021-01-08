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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about an AWS service that performed an action on an affected
    /// resource.
    /// </summary>
    public partial class AwsService
    {
        private string _invokedBy;

        /// <summary>
        /// Gets and sets the property InvokedBy. 
        /// <para>
        /// The name of the AWS service that performed the action.
        /// </para>
        /// </summary>
        public string InvokedBy
        {
            get { return this._invokedBy; }
            set { this._invokedBy = value; }
        }

        // Check to see if InvokedBy property is set
        internal bool IsSetInvokedBy()
        {
            return this._invokedBy != null;
        }

    }
}