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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeManagedJobTemplate operation.
    /// View details of a managed job template.
    /// </summary>
    public partial class DescribeManagedJobTemplateRequest : AmazonIoTRequest
    {
        private string _templateName;
        private string _templateVersion;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The unique name of a managed job template, which is required.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateVersion. 
        /// <para>
        /// An optional parameter to specify version of a managed template. If not specified,
        /// the pre-defined default version is returned.
        /// </para>
        /// </summary>
        public string TemplateVersion
        {
            get { return this._templateVersion; }
            set { this._templateVersion = value; }
        }

        // Check to see if TemplateVersion property is set
        internal bool IsSetTemplateVersion()
        {
            return this._templateVersion != null;
        }

    }
}