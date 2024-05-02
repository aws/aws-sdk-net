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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTemplate operation.
    /// Updates an email template. Email templates enable you to send personalized email to
    /// one or more destinations in a single operation. For more information, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/send-personalized-email-api.html">Amazon
    /// SES Developer Guide</a>.
    /// 
    ///  
    /// <para>
    /// You can execute this operation no more than once per second.
    /// </para>
    /// </summary>
    public partial class UpdateTemplateRequest : AmazonSimpleEmailServiceRequest
    {
        private Template _template;

        /// <summary>
        /// Gets and sets the property Template.
        /// </summary>
        [AWSProperty(Required=true)]
        public Template Template
        {
            get { return this._template; }
            set { this._template = value; }
        }

        // Check to see if Template property is set
        internal bool IsSetTemplate()
        {
            return this._template != null;
        }

    }
}