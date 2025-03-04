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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a contact method.
    /// 
    ///  
    /// <para>
    /// A contact method is a way to send you notifications. For more information, see <a
    /// href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-notifications">Notifications
    /// in Amazon Lightsail</a>.
    /// </para>
    /// </summary>
    public partial class ContactMethod
    {
        private string _arn;
        private string _contactEndpoint;
        private DateTime? _createdAt;
        private ResourceLocation _location;
        private string _name;
        private ContactProtocol _protocol;
        private ResourceType _resourceType;
        private ContactMethodStatus _status;
        private string _supportCode;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the contact method.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ContactEndpoint. 
        /// <para>
        /// The destination of the contact method, such as an email address or a mobile phone
        /// number.
        /// </para>
        /// </summary>
        public string ContactEndpoint
        {
            get { return this._contactEndpoint; }
            set { this._contactEndpoint = value; }
        }

        // Check to see if ContactEndpoint property is set
        internal bool IsSetContactEndpoint()
        {
            return this._contactEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the contact method was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// An object that describes the location of the contact method, such as the Amazon Web
        /// Services Region and Availability Zone.
        /// </para>
        /// </summary>
        public ResourceLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the contact method.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol of the contact method, such as email or SMS (text messaging).
        /// </para>
        /// </summary>
        public ContactProtocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The Lightsail resource type of the contact method.
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the contact method.
        /// </para>
        ///  
        /// <para>
        /// A contact method has the following possible status:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PendingVerification</c> - The contact method has not yet been verified, and the
        /// verification has not yet expired.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Valid</c> - The contact method has been verified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InValid</c> - An attempt was made to verify the contact method, but the verification
        /// has expired.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ContactMethodStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SupportCode. 
        /// <para>
        /// The support code. Include this code in your email to support when you have questions
        /// about your Lightsail contact method. This code enables our support team to look up
        /// your Lightsail information more easily.
        /// </para>
        /// </summary>
        public string SupportCode
        {
            get { return this._supportCode; }
            set { this._supportCode = value; }
        }

        // Check to see if SupportCode property is set
        internal bool IsSetSupportCode()
        {
            return this._supportCode != null;
        }

    }
}