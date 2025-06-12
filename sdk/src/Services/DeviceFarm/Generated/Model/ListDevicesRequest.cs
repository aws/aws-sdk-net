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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Container for the parameters to the ListDevices operation.
    /// Gets information about unique device types.
    /// </summary>
    public partial class ListDevicesRequest : AmazonDeviceFarmRequest
    {
        private string _arn;
        private List<DeviceFilter> _filters = AWSConfigs.InitializeCollections ? new List<DeviceFilter>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=1011)]
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
        /// Gets and sets the property Filters. 
        /// <para>
        /// Used to select a set of devices. A filter is made up of an attribute, an operator,
        /// and one or more values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Attribute: The aspect of a device such as platform or model used as the selection
        /// criteria in a device filter.
        /// </para>
        ///  
        /// <para>
        /// Allowed values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ARN: The Amazon Resource Name (ARN) of the device (for example, <c>arn:aws:devicefarm:us-west-2::device:12345Example</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PLATFORM: The device platform. Valid values are ANDROID or IOS.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OS_VERSION: The operating system version (for example, 10.3.2).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MODEL: The device model (for example, iPad 5th Gen).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AVAILABILITY: The current availability of the device. Valid values are AVAILABLE,
        /// HIGHLY_AVAILABLE, BUSY, or TEMPORARY_NOT_AVAILABLE.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FORM_FACTOR: The device form factor. Valid values are PHONE or TABLET.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MANUFACTURER: The device manufacturer (for example, Apple).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// REMOTE_ACCESS_ENABLED: Whether the device is enabled for remote access. Valid values
        /// are TRUE or FALSE.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// REMOTE_DEBUG_ENABLED: Whether the device is enabled for remote debugging. Valid values
        /// are TRUE or FALSE. Because remote debugging is <a href="https://docs.aws.amazon.com/devicefarm/latest/developerguide/history.html">no
        /// longer supported</a>, this attribute is ignored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTANCE_ARN: The Amazon Resource Name (ARN) of the device instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTANCE_LABELS: The label of the device instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FLEET_TYPE: The fleet type. Valid values are PUBLIC or PRIVATE.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Operator: The filter operator.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The EQUALS operator is available for every attribute except INSTANCE_LABELS.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The CONTAINS operator is available for the INSTANCE_LABELS and MODEL attributes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The IN and NOT_IN operators are available for the ARN, OS_VERSION, MODEL, MANUFACTURER,
        /// and INSTANCE_ARN attributes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The LESS_THAN, GREATER_THAN, LESS_THAN_OR_EQUALS, and GREATER_THAN_OR_EQUALS operators
        /// are also available for the OS_VERSION attribute.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Values: An array of one or more filter values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The IN and NOT_IN operators take a values array that has one or more elements.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The other operators require an array with a single element.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In a request, the AVAILABILITY attribute takes the following values: AVAILABLE, HIGHLY_AVAILABLE,
        /// BUSY, or TEMPORARY_NOT_AVAILABLE.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeviceFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier that was returned from the previous call to this operation, which can
        /// be used to return the next set of items in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1024)]
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

    }
}