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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.MailManager.Model
{
    /// <summary>
    /// The string to evaluate in a string condition expression.
    /// </summary>
    public partial class RuleStringToEvaluate
    {
        /// <summary>
        /// Gets and sets the property Analysis. 
        /// <para>
        /// The Add On ARN and its returned value to evaluate in a string condition expression.
        /// </para>
        /// </summary>
        public Analysis Analysis { get; set; }

        /// <summary>
        /// Checks to see if the Analysis property is set.
        /// </summary>
        internal bool IsSetAnalysis() => this.Analysis != null;

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The email attribute to evaluate in a string condition expression.
        /// </para>
        /// </summary>
        public RuleStringEmailAttribute Attribute { get; set; }

        /// <summary>
        /// Checks to see if the Attribute property is set.
        /// </summary>
        internal bool IsSetAttribute() => this.Attribute != null;

        /// <summary>
        /// Gets and sets the property ClientCertificateAttribute. 
        /// <para>
        /// The client certificate attribute to evaluate in a string condition expression.
        /// </para>
        /// </summary>
        public RuleClientCertificateAttribute ClientCertificateAttribute { get; set; }

        /// <summary>
        /// Checks to see if the ClientCertificateAttribute property is set.
        /// </summary>
        internal bool IsSetClientCertificateAttribute() => this.ClientCertificateAttribute != null;

        /// <summary>
        /// Gets and sets the property MimeHeaderAttribute. 
        /// <para>
        /// The email MIME X-Header attribute to evaluate in a string condition expression.
        /// </para>
        /// </summary>
        public string MimeHeaderAttribute { get; set; }

        /// <summary>
        /// Checks to see if the MimeHeaderAttribute property is set.
        /// </summary>
        internal bool IsSetMimeHeaderAttribute() => this.MimeHeaderAttribute != null;
    }
}
