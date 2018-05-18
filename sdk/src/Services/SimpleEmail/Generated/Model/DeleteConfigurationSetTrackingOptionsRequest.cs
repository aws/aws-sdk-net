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
    /// Container for the parameters to the DeleteConfigurationSetTrackingOptions operation.
    /// Deletes an association between a configuration set and a custom domain for open and
    /// click event tracking.
    /// 
    ///  
    /// <para>
    /// By default, images and links used for tracking open and click events are hosted on
    /// domains operated by Amazon SES. You can configure a subdomain of your own to handle
    /// these events. For information about using custom domains, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/configure-custom-open-click-domains.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Deleting this kind of association will result in emails sent using the specified configuration
    /// set to capture open and click events using the standard, Amazon SES-operated domains.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteConfigurationSetTrackingOptionsRequest : AmazonSimpleEmailServiceRequest
    {
        private string _configurationSetName;

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set from which you want to delete the tracking options.
        /// </para>
        /// </summary>
        public string ConfigurationSetName
        {
            get { return this._configurationSetName; }
            set { this._configurationSetName = value; }
        }

        // Check to see if ConfigurationSetName property is set
        internal bool IsSetConfigurationSetName()
        {
            return this._configurationSetName != null;
        }

    }
}