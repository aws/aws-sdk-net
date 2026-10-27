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
    /// The settings for a custom message activity. This type of activity calls an AWS Lambda
    /// function or web hook that sends messages to participants.
    /// </summary>
    public partial class CustomMessageActivity
    {
        /// <summary>
        /// Gets and sets the property DeliveryUri. 
        /// <para>
        /// The destination to send the campaign or treatment to. This value can be one of the
        /// following:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// The name or Amazon Resource Name (ARN) of an AWS Lambda function to invoke to handle
        /// delivery of the campaign or treatment.
        /// </para>
        /// </li> <li>
        /// <para>
        /// The URL for a web application or service that supports HTTPS and can receive the message.
        /// The URL has to be a full URL, including the HTTPS protocol.
        /// </para>
        /// </li></ul>
        /// </summary>
        public string DeliveryUri { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryUri property is set.
        /// </summary>
        internal bool IsSetDeliveryUri() => this.DeliveryUri != null;

        /// <summary>
        /// Gets and sets the property EndpointTypes. 
        /// <para>
        /// The types of endpoints to send the custom message to. Each valid value maps to a type
        /// of channel that you can associate with an endpoint by using the ChannelType property
        /// of an endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EndpointTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EndpointTypes property is set.
        /// </summary>
        internal bool IsSetEndpointTypes() => this.EndpointTypes != null && (this.EndpointTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MessageConfig. 
        /// <para>
        /// Specifies the message data included in a custom channel message that's sent to participants
        /// in a journey.
        /// </para>
        /// </summary>
        public JourneyCustomMessage MessageConfig { get; set; }

        /// <summary>
        /// Checks to see if the MessageConfig property is set.
        /// </summary>
        internal bool IsSetMessageConfig() => this.MessageConfig != null;

        /// <summary>
        /// Gets and sets the property NextActivity. 
        /// <para>
        /// The unique identifier for the next activity to perform, after Amazon Pinpoint calls
        /// the AWS Lambda function or web hook.
        /// </para>
        /// </summary>
        public string NextActivity { get; set; }

        /// <summary>
        /// Checks to see if the NextActivity property is set.
        /// </summary>
        internal bool IsSetNextActivity() => this.NextActivity != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the custom message template to use for the message. If specified, this
        /// value must match the name of an existing message template.
        /// </para>
        /// </summary>
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;

        /// <summary>
        /// Gets and sets the property TemplateVersion. 
        /// <para>
        /// The unique identifier for the version of the message template to use for the message.
        /// If specified, this value must match the identifier for an existing template version.
        /// To retrieve a list of versions and version identifiers for a template, use the <link
        /// linkend="templates-template-name-template-type-versions">Template Versions</link>
        /// resource.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for this property, Amazon Pinpoint uses the <i>active
        /// version</i> of the template. The <i>active version</i> is typically the version of
        /// a template that's been most recently reviewed and approved for use, depending on your
        /// workflow. It isn't necessarily the latest version of a template.
        /// </para>
        /// </summary>
        public string TemplateVersion { get; set; }

        /// <summary>
        /// Checks to see if the TemplateVersion property is set.
        /// </summary>
        internal bool IsSetTemplateVersion() => this.TemplateVersion != null;
    }
}
