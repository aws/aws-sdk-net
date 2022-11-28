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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// An attribute is a name-value pair that's associated with an Amazon ECS object. Use
    /// attributes to extend the Amazon ECS data model by adding custom metadata to your resources.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-placement-constraints.html#attributes">Attributes</a>
    /// in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </summary>
    public partial class Attribute
    {
        private string _name;
        private string _targetId;
        private TargetType _targetType;
        private string _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the attribute. The <code>name</code> must contain between 1 and 128 characters.
        /// The name may contain letters (uppercase and lowercase), numbers, hyphens (-), underscores
        /// (_), forward slashes (/), back slashes (\), or periods (.).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TargetId. 
        /// <para>
        /// The ID of the target. You can specify the short form ID for a resource or the full
        /// Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public string TargetId
        {
            get { return this._targetId; }
            set { this._targetId = value; }
        }

        // Check to see if TargetId property is set
        internal bool IsSetTargetId()
        {
            return this._targetId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The type of the target to attach the attribute with. This parameter is required if
        /// you use the short form ID for a resource instead of the full ARN.
        /// </para>
        /// </summary>
        public TargetType TargetType
        {
            get { return this._targetType; }
            set { this._targetType = value; }
        }

        // Check to see if TargetType property is set
        internal bool IsSetTargetType()
        {
            return this._targetType != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the attribute. The <code>value</code> must contain between 1 and 128
        /// characters. It can contain letters (uppercase and lowercase), numbers, hyphens (-),
        /// underscores (_), periods (.), at signs (@), forward slashes (/), back slashes (\),
        /// colons (:), or spaces. The value can't start or end with a space.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}