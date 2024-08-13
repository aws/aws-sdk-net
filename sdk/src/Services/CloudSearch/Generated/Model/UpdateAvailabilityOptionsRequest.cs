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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
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
namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAvailabilityOptions operation.
    /// Configures the availability options for a domain. Enabling the Multi-AZ option expands
    /// an Amazon CloudSearch domain to an additional Availability Zone in the same Region
    /// to increase fault tolerance in the event of a service disruption. Changes to the Multi-AZ
    /// option can take about half an hour to become active. For more information, see <a
    /// href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-availability-options.html"
    /// target="_blank">Configuring Availability Options</a> in the <i>Amazon CloudSearch
    /// Developer Guide</i>.
    /// </summary>
    public partial class UpdateAvailabilityOptionsRequest : AmazonCloudSearchRequest
    {
        private string _domainName;
        private bool? _multiAZ;

        /// <summary>
        /// Gets and sets the property DomainName.
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=28)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// You expand an existing search domain to a second Availability Zone by setting the
        /// Multi-AZ option to true. Similarly, you can turn off the Multi-AZ option to downgrade
        /// the domain to a single Availability Zone by setting the Multi-AZ option to <c>false</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? MultiAZ
        {
            get { return this._multiAZ; }
            set { this._multiAZ = value; }
        }

        // Check to see if MultiAZ property is set
        internal bool IsSetMultiAZ()
        {
            return this._multiAZ.HasValue; 
        }

    }
}