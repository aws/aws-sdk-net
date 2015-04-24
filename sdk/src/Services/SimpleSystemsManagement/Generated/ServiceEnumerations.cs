/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SimpleSystemsManagement
{

    /// <summary>
    /// Constants used for properties of type AssociationFilterKey.
    /// </summary>
    public class AssociationFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant InstanceId for AssociationFilterKey
        /// </summary>
        public static readonly AssociationFilterKey InstanceId = new AssociationFilterKey("InstanceId");
        /// <summary>
        /// Constant Name for AssociationFilterKey
        /// </summary>
        public static readonly AssociationFilterKey Name = new AssociationFilterKey("Name");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public AssociationFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationFilterKey FindValue(string value)
        {
            return FindValue<AssociationFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssociationStatusName.
    /// </summary>
    public class AssociationStatusName : ConstantClass
    {

        /// <summary>
        /// Constant Failed for AssociationStatusName
        /// </summary>
        public static readonly AssociationStatusName Failed = new AssociationStatusName("Failed");
        /// <summary>
        /// Constant Pending for AssociationStatusName
        /// </summary>
        public static readonly AssociationStatusName Pending = new AssociationStatusName("Pending");
        /// <summary>
        /// Constant Success for AssociationStatusName
        /// </summary>
        public static readonly AssociationStatusName Success = new AssociationStatusName("Success");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public AssociationStatusName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssociationStatusName FindValue(string value)
        {
            return FindValue<AssociationStatusName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssociationStatusName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentFilterKey.
    /// </summary>
    public class DocumentFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant Name for DocumentFilterKey
        /// </summary>
        public static readonly DocumentFilterKey Name = new DocumentFilterKey("Name");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public DocumentFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentFilterKey FindValue(string value)
        {
            return FindValue<DocumentFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentStatus.
    /// </summary>
    public class DocumentStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus Active = new DocumentStatus("Active");
        /// <summary>
        /// Constant Creating for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus Creating = new DocumentStatus("Creating");
        /// <summary>
        /// Constant Deleting for DocumentStatus
        /// </summary>
        public static readonly DocumentStatus Deleting = new DocumentStatus("Deleting");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public DocumentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentStatus FindValue(string value)
        {
            return FindValue<DocumentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Fault.
    /// </summary>
    public class Fault : ConstantClass
    {

        /// <summary>
        /// Constant Client for Fault
        /// </summary>
        public static readonly Fault Client = new Fault("Client");
        /// <summary>
        /// Constant Server for Fault
        /// </summary>
        public static readonly Fault Server = new Fault("Server");
        /// <summary>
        /// Constant Unknown for Fault
        /// </summary>
        public static readonly Fault Unknown = new Fault("Unknown");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Fault(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Fault FindValue(string value)
        {
            return FindValue<Fault>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Fault(string value)
        {
            return FindValue(value);
        }
    }

}