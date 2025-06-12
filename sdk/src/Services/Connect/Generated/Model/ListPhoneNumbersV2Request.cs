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
    /// Container for the parameters to the ListPhoneNumbersV2 operation.
    /// Lists phone numbers claimed to your Amazon Connect instance or traffic distribution
    /// group. If the provided <c>TargetArn</c> is a traffic distribution group, you can call
    /// this API in both Amazon Web Services Regions associated with traffic distribution
    /// group.
    /// 
    ///  
    /// <para>
    /// For more information about phone numbers, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-center-phone-number.html">Set
    /// Up Phone Numbers for Your Contact Center</a> in the <i>Amazon Connect Administrator
    /// Guide</i>.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// When given an instance ARN, <c>ListPhoneNumbersV2</c> returns only the phone numbers
    /// claimed to the instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When given a traffic distribution group ARN <c>ListPhoneNumbersV2</c> returns only
    /// the phone numbers claimed to the traffic distribution group.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class ListPhoneNumbersV2Request : AmazonConnectRequest
    {
        private string _instanceId;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _phoneNumberCountryCodes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _phoneNumberPrefix;
        private List<string> _phoneNumberTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _targetArn;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance that phone numbers are claimed to. You
        /// can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance. If both <c>TargetArn</c>
        /// and <c>InstanceId</c> are not provided, this API lists numbers claimed to all the
        /// Amazon Connect instances belonging to your account in the same AWS Region as the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberCountryCodes. 
        /// <para>
        /// The ISO country code.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<string> PhoneNumberCountryCodes
        {
            get { return this._phoneNumberCountryCodes; }
            set { this._phoneNumberCountryCodes = value; }
        }

        // Check to see if PhoneNumberCountryCodes property is set
        internal bool IsSetPhoneNumberCountryCodes()
        {
            return this._phoneNumberCountryCodes != null && (this._phoneNumberCountryCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberPrefix. 
        /// <para>
        /// The prefix of the phone number. If provided, it must contain <c>+</c> as part of the
        /// country code.
        /// </para>
        /// </summary>
        public string PhoneNumberPrefix
        {
            get { return this._phoneNumberPrefix; }
            set { this._phoneNumberPrefix = value; }
        }

        // Check to see if PhoneNumberPrefix property is set
        internal bool IsSetPhoneNumberPrefix()
        {
            return this._phoneNumberPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberTypes. 
        /// <para>
        /// The type of phone number.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=6)]
        public List<string> PhoneNumberTypes
        {
            get { return this._phoneNumberTypes; }
            set { this._phoneNumberTypes = value; }
        }

        // Check to see if PhoneNumberTypes property is set
        internal bool IsSetPhoneNumberTypes()
        {
            return this._phoneNumberTypes != null && (this._phoneNumberTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for Amazon Connect instances or traffic distribution
        /// groups that phone number inbound traffic is routed through. If both <c>TargetArn</c>
        /// and <c>InstanceId</c> input are not provided, this API lists numbers claimed to all
        /// the Amazon Connect instances belonging to your account in the same Amazon Web Services
        /// Region as the request.
        /// </para>
        /// </summary>
        public string TargetArn
        {
            get { return this._targetArn; }
            set { this._targetArn = value; }
        }

        // Check to see if TargetArn property is set
        internal bool IsSetTargetArn()
        {
            return this._targetArn != null;
        }

    }
}