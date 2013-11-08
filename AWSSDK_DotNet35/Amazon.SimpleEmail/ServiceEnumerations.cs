/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;

using Amazon.Runtime;


namespace Amazon.SimpleEmail
{


    /// <summary>Identity Type
    /// </summary>
    public class IdentityType : ConstantClass
    {


       /// <summary>Constant Domain for IdentityType
       /// </summary>
        public static readonly IdentityType Domain = new IdentityType("Domain");
    

       /// <summary>Constant EmailAddress for IdentityType
       /// </summary>
        public static readonly IdentityType EmailAddress = new IdentityType("EmailAddress");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public IdentityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IdentityType FindValue(string value)
        {
            return FindValue<IdentityType>(value);
        }

        public static implicit operator IdentityType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Notification Type
    /// </summary>
    public class NotificationType : ConstantClass
    {


       /// <summary>Constant Bounce for NotificationType
       /// </summary>
        public static readonly NotificationType Bounce = new NotificationType("Bounce");
    

       /// <summary>Constant Complaint for NotificationType
       /// </summary>
        public static readonly NotificationType Complaint = new NotificationType("Complaint");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public NotificationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotificationType FindValue(string value)
        {
            return FindValue<NotificationType>(value);
        }

        public static implicit operator NotificationType(string value)
        {
            return FindValue(value);
        }
    }
    

    /// <summary>Verification Status
    /// </summary>
    public class VerificationStatus : ConstantClass
    {


       /// <summary>Constant Failed for VerificationStatus
       /// </summary>
        public static readonly VerificationStatus Failed = new VerificationStatus("Failed");
    

       /// <summary>Constant NotStarted for VerificationStatus
       /// </summary>
        public static readonly VerificationStatus NotStarted = new VerificationStatus("NotStarted");
    

       /// <summary>Constant Pending for VerificationStatus
       /// </summary>
        public static readonly VerificationStatus Pending = new VerificationStatus("Pending");
    

       /// <summary>Constant Success for VerificationStatus
       /// </summary>
        public static readonly VerificationStatus Success = new VerificationStatus("Success");
    

       /// <summary>Constant TemporaryFailure for VerificationStatus
       /// </summary>
        public static readonly VerificationStatus TemporaryFailure = new VerificationStatus("TemporaryFailure");
    

        /// <summary>
        /// Default Constructor
        /// </summary>
        public VerificationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VerificationStatus FindValue(string value)
        {
            return FindValue<VerificationStatus>(value);
        }

        public static implicit operator VerificationStatus(string value)
        {
            return FindValue(value);
        }
    }
    

}
        
