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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides information about a specific version of a message template.
    /// </summary>
    public partial class TemplateVersionResponse
    {
        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date, in ISO 8601 format, when the version of the message template was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate != null;

        /// <summary>
        /// Gets and sets the property DefaultSubstitutions. 
        /// <para>
        /// A JSON object that specifies the default values that are used for message variables
        /// in the version of the message template. This object is a set of key-value pairs. Each
        /// key defines a message variable in the template. The corresponding value defines the
        /// default value for that variable.
        /// </para>
        /// </summary>
        public string DefaultSubstitutions { get; set; }

        /// <summary>
        /// Checks to see if the DefaultSubstitutions property is set.
        /// </summary>
        internal bool IsSetDefaultSubstitutions() => this.DefaultSubstitutions != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date, in ISO 8601 format, when the version of the message template was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate != null;

        /// <summary>
        /// Gets and sets the property TemplateDescription. 
        /// <para>
        /// The custom description of the version of the message template.
        /// </para>
        /// </summary>
        public string TemplateDescription { get; set; }

        /// <summary>
        /// Checks to see if the TemplateDescription property is set.
        /// </summary>
        internal bool IsSetTemplateDescription() => this.TemplateDescription != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the message template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;

        /// <summary>
        /// Gets and sets the property TemplateType. 
        /// <para>
        /// The type of channel that the message template is designed for. Possible values are:
        /// EMAIL, PUSH, SMS, INAPP, and VOICE.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TemplateType { get; set; }

        /// <summary>
        /// Checks to see if the TemplateType property is set.
        /// </summary>
        internal bool IsSetTemplateType() => this.TemplateType != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The unique identifier for the version of the message template. This value is an integer
        /// that Amazon Pinpoint automatically increments and assigns to each new version of a
        /// template.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
