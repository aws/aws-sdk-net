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
    /// Container for the parameters to the CreateContactMethod operation.
    /// Creates an email or SMS text message contact method.
    /// 
    ///  
    /// <para>
    /// A contact method is used to send you notifications about your Amazon Lightsail resources.
    /// You can add one email address and one mobile phone number contact method in each Amazon
    /// Web Services Region. However, SMS text messaging is not supported in some Amazon Web
    /// Services Regions, and SMS text messages cannot be sent to some countries/regions.
    /// For more information, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-notifications">Notifications
    /// in Amazon Lightsail</a>.
    /// </para>
    ///  
    /// <para>
    /// The <c>create contact method</c> operation supports tag-based access control via request
    /// tags. For more information, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-controlling-access-using-tags">Lightsail
    /// Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateContactMethodRequest : AmazonLightsailRequest
    {
        private string _contactEndpoint;
        private ContactProtocol _protocol;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ContactEndpoint. 
        /// <para>
        /// The destination of the contact method, such as an email address or a mobile phone
        /// number.
        /// </para>
        ///  
        /// <para>
        /// Use the E.164 format when specifying a mobile phone number. E.164 is a standard for
        /// the phone number structure used for international telecommunication. Phone numbers
        /// that follow this format can have a maximum of 15 digits, and they are prefixed with
        /// the plus character (+) and the country code. For example, a U.S. phone number in E.164
        /// format would be specified as +1XXX5550100. For more information, see <a href="https://en.wikipedia.org/wiki/E.164">E.164</a>
        /// on <i>Wikipedia</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol of the contact method, such as <c>Email</c> or <c>SMS</c> (text messaging).
        /// </para>
        ///  
        /// <para>
        /// The <c>SMS</c> protocol is supported only in the following Amazon Web Services Regions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// US East (N. Virginia) (<c>us-east-1</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// US West (Oregon) (<c>us-west-2</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Europe (Ireland) (<c>eu-west-1</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Tokyo) (<c>ap-northeast-1</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Singapore) (<c>ap-southeast-1</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asia Pacific (Sydney) (<c>ap-southeast-2</c>)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a list of countries/regions where SMS text messages can be sent, and the latest
        /// Amazon Web Services Regions where SMS text messaging is supported, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-supported-regions-countries.html">Supported
        /// Regions and Countries</a> in the <i>Amazon SNS Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about notifications in Amazon Lightsail, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-notifications">Notifications
        /// in Amazon Lightsail</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values to add to the contact method during create.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>TagResource</c> action to tag a resource after it's created.
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

    }
}