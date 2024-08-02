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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
    /// The structure of an ingress endpoint resource.
    /// </summary>
    public partial class IngressPoint
    {
        private string _aRecord;
        private string _ingressPointId;
        private string _ingressPointName;
        private IngressPointStatus _status;
        private IngressPointType _type;

        /// <summary>
        /// Gets and sets the property ARecord. 
        /// <para>
        ///  The DNS A Record that identifies your ingress endpoint. Configure your DNS Mail Exchange
        /// (MX) record with this value to route emails to Mail Manager. 
        /// </para>
        /// </summary>
        public string ARecord
        {
            get { return this._aRecord; }
            set { this._aRecord = value; }
        }

        // Check to see if ARecord property is set
        internal bool IsSetARecord()
        {
            return this._aRecord != null;
        }

        /// <summary>
        /// Gets and sets the property IngressPointId. 
        /// <para>
        /// The identifier of the ingress endpoint resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string IngressPointId
        {
            get { return this._ingressPointId; }
            set { this._ingressPointId = value; }
        }

        // Check to see if IngressPointId property is set
        internal bool IsSetIngressPointId()
        {
            return this._ingressPointId != null;
        }

        /// <summary>
        /// Gets and sets the property IngressPointName. 
        /// <para>
        /// A user friendly name for the ingress endpoint resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string IngressPointName
        {
            get { return this._ingressPointName; }
            set { this._ingressPointName = value; }
        }

        // Check to see if IngressPointName property is set
        internal bool IsSetIngressPointName()
        {
            return this._ingressPointName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the ingress endpoint resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IngressPointStatus Status
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of ingress endpoint resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IngressPointType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}