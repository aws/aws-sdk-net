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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Container for the parameters to the GetSMSAttributes operation.
    /// Returns the settings for sending SMS messages from your account.
    /// 
    ///  
    /// <para>
    /// These settings are set with the <code>SetSMSAttributes</code> action.
    /// </para>
    /// </summary>
    public partial class GetSMSAttributesRequest : AmazonSimpleNotificationServiceRequest
    {
        private List<string> _attributes = new List<string>();

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A list of the individual attribute names, such as <code>MonthlySpendLimit</code>,
        /// for which you want values.
        /// </para>
        ///  
        /// <para>
        /// For all attribute names, see <a href="http://docs.aws.amazon.com/sns/latest/api/API_SetSMSAttributes.html">SetSMSAttributes</a>.
        /// </para>
        ///  
        /// <para>
        /// If you don't use this parameter, Amazon SNS returns all SMS attributes.
        /// </para>
        /// </summary>
        public List<string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

    }
}