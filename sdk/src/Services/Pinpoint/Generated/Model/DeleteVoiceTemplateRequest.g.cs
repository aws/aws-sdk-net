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
    /// Container for the parameters to the DeleteVoiceTemplate operation. Deletes a message
    /// template for messages that were sent through the voice channel.
    /// </summary>
    public partial class DeleteVoiceTemplateRequest : AmazonPinpointRequest
    {
        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the message template. A template name must start with an alphanumeric
        /// character and can contain a maximum of 128 characters. The characters can be alphanumeric
        /// characters, underscores (_), or hyphens (-). Template names are case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The unique identifier for the version of the message template to update, retrieve
        /// information about, or delete. To retrieve identifiers and other information for all
        /// the versions of a template, use the <link linkend="templates-template-name-template-type-versions">Template
        /// Versions</link> resource.
        /// </para>
        ///  
        /// <para>
        /// If specified, this value must match the identifier for an existing template version.
        /// If specified for an update operation, this value must match the identifier for the
        /// latest existing version of the template. This restriction helps ensure that race conditions
        /// don't occur.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for this parameter, Amazon Pinpoint does the following:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// For a get operation, retrieves information about the active version of the template.
        /// </para>
        /// </li> <li>
        /// <para>
        /// For an update operation, saves the updates to (overwrites) the latest existing version
        /// of the template, if the create-new-version parameter isn't used or is set to false.
        /// </para>
        /// </li> <li>
        /// <para>
        /// For a delete operation, deletes the template, including all versions of the template.
        /// </para>
        /// </li></ul>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
