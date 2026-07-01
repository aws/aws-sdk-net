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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// The content of an outbound web notification, including the notification type, the
    /// view to render, and any optional attributes used to populate the view.
    /// </summary>
    public partial class WebNotificationContent
    {
        private ContentAttributes _attributes;
        private NotificationType _type;
        private string _viewArn;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Optional attributes used to populate the notification content, such as recommender
        /// configuration for personalized content.
        /// </para>
        /// </summary>
        public ContentAttributes Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of web notification to send.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotificationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property ViewArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the view to render for the notification.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string ViewArn
        {
            get { return this._viewArn; }
            set { this._viewArn = value; }
        }

        // Check to see if ViewArn property is set
        internal bool IsSetViewArn()
        {
            return this._viewArn != null;
        }

    }
}