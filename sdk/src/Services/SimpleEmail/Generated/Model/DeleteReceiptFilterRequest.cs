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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteReceiptFilter operation.
    /// Deletes the specified IP address filter.
    /// 
    ///  
    /// <para>
    /// For information about managing IP address filters, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-managing-ip-filters.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// This action is throttled at one request per second.
    /// </para>
    /// </summary>
    public partial class DeleteReceiptFilterRequest : AmazonSimpleEmailServiceRequest
    {
        private string _filterName;

        /// <summary>
        /// Gets and sets the property FilterName. 
        /// <para>
        /// The name of the IP address filter to delete.
        /// </para>
        /// </summary>
        public string FilterName
        {
            get { return this._filterName; }
            set { this._filterName = value; }
        }

        // Check to see if FilterName property is set
        internal bool IsSetFilterName()
        {
            return this._filterName != null;
        }

    }
}