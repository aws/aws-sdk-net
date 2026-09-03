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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
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
namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeServices operation.
    /// Returns the current list of Amazon Web Services services and a list of service categories
    /// for each service. You then use service names and categories in your <a>CreateCase</a>
    /// requests. Each Amazon Web Services service has its own set of categories.
    /// 
    ///  
    /// <para>
    /// The service codes and category codes correspond to the values that appear in the <b>Service</b>
    /// and <b>Category</b> lists on the Amazon Web Services Support Center <a href="https://console.aws.amazon.com/support/home#/case/create">Create
    /// Case</a> page. The values in those fields don't necessarily match the service codes
    /// and categories returned by the <c>DescribeServices</c> operation. Always use the service
    /// codes and categories that the <c>DescribeServices</c> operation returns, so that you
    /// have the most recent set of service and category codes.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// You must have an Amazon Web Services Business Support+, Amazon Web Services Enterprise
    /// Support, or Amazon Web Services Unified Operations plan to use the Amazon Web Services
    /// Support API. If you're in an Amazon Web Services Region that doesn't offer one of
    /// these Amazon Web Services Support plans, or if you haven't transitioned to one of
    /// these plans, you can use the Amazon Web Services Support API with a Business, Enterprise
    /// On-Ramp, or Enterprise Support plan.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you call the Amazon Web Services Support API from an account that doesn't have
    /// an Amazon Web Services Business Support+, Amazon Web Services Enterprise Support,
    /// or Amazon Web Services Unified Operations plan, the <c>SubscriptionRequiredException</c>
    /// error message appears. For information about changing your support plan, see <a href="http://aws.amazon.com/premiumsupport/">Amazon
    /// Web Services Support</a>.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class DescribeServicesRequest : AmazonAWSSupportRequest
    {
        private bool? _dryRun;
        private string _language;
        private List<string> _serviceCodeList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Specifies whether to validate the request without actually returning the list of services.
        /// When set to <c>true</c>, the request is validated but no services are returned, and
        /// the operation returns a <c>DryRunOperationException</c>. When omitted or set to <c>false</c>,
        /// the request runs normally.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The language in which Amazon Web Services Support handles the case. Amazon Web Services
        /// Support currently supports Chinese (“zh”), English ("en"), Japanese ("ja") , Chinese
        /// ("zh"), Spanish ("es"), Portuguese ("pt"), French ("fr"), Korean (“ko”), and Turkish
        /// ("tr"). You must specify the ISO 639-1 code for the <c>language</c> parameter if you
        /// want support in that language.
        /// </para>
        /// </summary>
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCodeList. 
        /// <para>
        /// A JSON-formatted list of service codes available for Amazon Web Services services.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> ServiceCodeList
        {
            get { return this._serviceCodeList; }
            set { this._serviceCodeList = value; }
        }

        // Check to see if ServiceCodeList property is set
        internal bool IsSetServiceCodeList()
        {
            return this._serviceCodeList != null && (this._serviceCodeList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}