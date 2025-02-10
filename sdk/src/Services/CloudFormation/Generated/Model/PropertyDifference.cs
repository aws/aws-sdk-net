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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Information about a resource property whose actual value differs from its expected
    /// value, as defined in the stack template and any values specified as template parameters.
    /// These will be present only for resources whose <c>StackResourceDriftStatus</c> is
    /// <c>MODIFIED</c>. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-drift.html">Detect
    /// unmanaged configuration changes to stacks and resources with drift detection</a>.
    /// </summary>
    public partial class PropertyDifference
    {
        private string _actualValue;
        private DifferenceType _differenceType;
        private string _expectedValue;
        private string _propertyPath;

        /// <summary>
        /// Gets and sets the property ActualValue. 
        /// <para>
        /// The actual property value of the resource property.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ActualValue
        {
            get { return this._actualValue; }
            set { this._actualValue = value; }
        }

        // Check to see if ActualValue property is set
        internal bool IsSetActualValue()
        {
            return this._actualValue != null;
        }

        /// <summary>
        /// Gets and sets the property DifferenceType. 
        /// <para>
        /// The type of property difference.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ADD</c>: A value has been added to a resource property that's an array or list
        /// data type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REMOVE</c>: The property has been removed from the current resource configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_EQUAL</c>: The current property value differs from its expected value (as
        /// defined in the stack template and any values specified as template parameters).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public DifferenceType DifferenceType
        {
            get { return this._differenceType; }
            set { this._differenceType = value; }
        }

        // Check to see if DifferenceType property is set
        internal bool IsSetDifferenceType()
        {
            return this._differenceType != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedValue. 
        /// <para>
        /// The expected property value of the resource property, as defined in the stack template
        /// and any values specified as template parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExpectedValue
        {
            get { return this._expectedValue; }
            set { this._expectedValue = value; }
        }

        // Check to see if ExpectedValue property is set
        internal bool IsSetExpectedValue()
        {
            return this._expectedValue != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyPath. 
        /// <para>
        /// The fully-qualified path to the resource property.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PropertyPath
        {
            get { return this._propertyPath; }
            set { this._propertyPath = value; }
        }

        // Check to see if PropertyPath property is set
        internal bool IsSetPropertyPath()
        {
            return this._propertyPath != null;
        }

    }
}