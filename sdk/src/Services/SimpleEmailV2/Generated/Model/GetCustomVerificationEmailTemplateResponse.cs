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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// The following elements are returned by the service.
    /// </summary>
    public partial class GetCustomVerificationEmailTemplateResponse : AmazonWebServiceResponse
    {
        private string _failureRedirectionURL;
        private string _fromEmailAddress;
        private string _successRedirectionURL;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _templateContent;
        private string _templateName;
        private string _templateSubject;

        /// <summary>
        /// Gets and sets the property FailureRedirectionURL. 
        /// <para>
        /// The URL that the recipient of the verification email is sent to if his or her address
        /// is not successfully verified.
        /// </para>
        /// </summary>
        public string FailureRedirectionURL
        {
            get { return this._failureRedirectionURL; }
            set { this._failureRedirectionURL = value; }
        }

        // Check to see if FailureRedirectionURL property is set
        internal bool IsSetFailureRedirectionURL()
        {
            return this._failureRedirectionURL != null;
        }

        /// <summary>
        /// Gets and sets the property FromEmailAddress. 
        /// <para>
        /// The email address that the custom verification email is sent from.
        /// </para>
        /// </summary>
        public string FromEmailAddress
        {
            get { return this._fromEmailAddress; }
            set { this._fromEmailAddress = value; }
        }

        // Check to see if FromEmailAddress property is set
        internal bool IsSetFromEmailAddress()
        {
            return this._fromEmailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property SuccessRedirectionURL. 
        /// <para>
        /// The URL that the recipient of the verification email is sent to if his or her address
        /// is successfully verified.
        /// </para>
        /// </summary>
        public string SuccessRedirectionURL
        {
            get { return this._successRedirectionURL; }
            set { this._successRedirectionURL = value; }
        }

        // Check to see if SuccessRedirectionURL property is set
        internal bool IsSetSuccessRedirectionURL()
        {
            return this._successRedirectionURL != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of objects that define the tags (keys and values) that are associated with
        /// the custom verification email template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TemplateContent. 
        /// <para>
        /// The content of the custom verification email.
        /// </para>
        /// </summary>
        public string TemplateContent
        {
            get { return this._templateContent; }
            set { this._templateContent = value; }
        }

        // Check to see if TemplateContent property is set
        internal bool IsSetTemplateContent()
        {
            return this._templateContent != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the custom verification email template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property TemplateSubject. 
        /// <para>
        /// The subject line of the custom verification email.
        /// </para>
        /// </summary>
        public string TemplateSubject
        {
            get { return this._templateSubject; }
            set { this._templateSubject = value; }
        }

        // Check to see if TemplateSubject property is set
        internal bool IsSetTemplateSubject()
        {
            return this._templateSubject != null;
        }

    }
}