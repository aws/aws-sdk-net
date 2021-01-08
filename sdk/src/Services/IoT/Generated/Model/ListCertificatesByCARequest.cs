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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the ListCertificatesByCA operation.
    /// List the device certificates signed by the specified CA certificate.
    /// </summary>
    public partial class ListCertificatesByCARequest : AmazonIoTRequest
    {
        private bool? _ascendingOrder;
        private string _caCertificateId;
        private string _marker;
        private int? _pageSize;

        /// <summary>
        /// Gets and sets the property AscendingOrder. 
        /// <para>
        /// Specifies the order for results. If True, the results are returned in ascending order,
        /// based on the creation date.
        /// </para>
        /// </summary>
        public bool AscendingOrder
        {
            get { return this._ascendingOrder.GetValueOrDefault(); }
            set { this._ascendingOrder = value; }
        }

        // Check to see if AscendingOrder property is set
        internal bool IsSetAscendingOrder()
        {
            return this._ascendingOrder.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CaCertificateId. 
        /// <para>
        /// The ID of the CA certificate. This operation will list all registered device certificate
        /// that were signed by this CA certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=64, Max=64)]
        public string CaCertificateId
        {
            get { return this._caCertificateId; }
            set { this._caCertificateId = value; }
        }

        // Check to see if CaCertificateId property is set
        internal bool IsSetCaCertificateId()
        {
            return this._caCertificateId != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The marker for the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The result page size.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public int PageSize
        {
            get { return this._pageSize.GetValueOrDefault(); }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

    }
}