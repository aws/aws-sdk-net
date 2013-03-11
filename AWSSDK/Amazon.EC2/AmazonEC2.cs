/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Amazon.EC2.Model;

namespace Amazon.EC2
{
    /// <summary>
    /// The Amazon Elastic Compute Cloud (Amazon EC2) web
    /// service provides you with
    /// the ability to execute your applications in
    /// Amazon's computing environment.
    /// To use Amazon EC2 you simply:
    /// 1. Create an Amazon Machine Image (AMI) containing all your software,
    /// including your operating system and associated configuration settings,
    /// applications, libraries, etc. Think of this as zipping up the contents
    /// of your hard drive. We provide all the necessary tools to create and
    /// package your AMI.
    /// 2. Upload this AMI to the Amazon S3 (Amazon Simple
    /// Storage Service) service. This gives us reliable,
    /// secure access to your AMI.
    /// 3. Register your AMI with Amazon EC2. This allows us to verify
    /// that your AMI has been uploaded correctly and to allocate a unique
    /// identifier for it.
    /// 4. Use this AMI ID and the Amazon EC2 web service
    /// APIs to run, monitor, and
    /// terminate as many instances of this AMI as
    /// required.
    /// You can also skip the first three steps and choose to launch
    /// an AMI that is provided by Amazon or shared by another user.
    /// While instances are running, you are billed for the computing
    /// and network resources that they consume.
    /// You can also skip the first three steps
    /// and choose to launch an AMI that is
    /// provided by Amazon or shared by
    /// another user.
    /// While instances are running, you are billed for the
    /// computing and network
    /// resources that they consume.
    /// </summary>
    public interface AmazonEC2 : IDisposable
    {
        /// <summary>
        /// Activates a license.
        /// </summary>
        /// <remarks>
        /// Activates a specific number of licenses for a 90-day period.
        /// Activations can be done against a specific license ID.
        /// </remarks>
        /// <param name="request">Activate License  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Activate License  Response from the service</returns>
        ActivateLicenseResponse ActivateLicense(ActivateLicenseRequest request);

        /// <summary>
        /// Acquires an elastic IP address for use with your account or your VPC.
        /// </summary>
        /// <param name="request">Allocate Address  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Allocate Address  Response from the service</returns>
        AllocateAddressResponse AllocateAddress(AllocateAddressRequest request);

        /// <summary>
        /// Associates an elastic IP address with an instance. If the IP address is
        /// currently assigned to another instance, the IP address is assigned
        /// to the new instance.
        /// </summary>
        /// <remarks>
        /// This is an idempotent operation. If you call it more than once, Amazon EC2 does not return an error.
        /// </remarks>
        /// <param name="request">Associate Address  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Associate Address  Response from the service</returns>
        AssociateAddressResponse AssociateAddress(AssociateAddressRequest request);

        /// <summary>
        /// Attaches an Amazon EBS volume to a running instance and exposes it with the
        /// specified device name.
        /// </summary>
        /// <remarks>
        /// Windows instances currently support devices xvda through xvdp. Devices
        /// xvda and xvdb are reserved by the operating system, xvdc is
        /// assigned to drive C:\, and, depending on the instance type, devices xvdd through
        /// xvde might be reserved by the instance stores. Any device that is not
        /// reserved can be attached to an Amazon EBS volume. For a list of
        /// devices that are reserved by the instance stores, go to the Amazon
        /// Elastic Compute Cloud Developer Guide.
        /// </remarks>
        /// <param name="request">Attach Volume  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Attach Volume  Response from the service</returns>
        AttachVolumeResponse AttachVolume(AttachVolumeRequest request);

        /// <summary>
        /// Adds one or more ingress rules to a security group.
        /// This action applies to both EC2 security groups and VPC security groups.
        /// </summary>
        /// <remarks>
        /// Permissions are specified by the IP protocol (TCP, UDP or ICMP),
        /// the source of the request (by IP range or an Amazon EC2 user-group pair),
        /// the source and destination port ranges (for TCP and UDP), and the
        /// ICMP codes and types (for ICMP). When authorizing ICMP, -1 can
        /// be used as a wildcard in the type and code fields.
        ///
        /// Permission changes are propagated to instances within the
        /// security group as quickly as possible. However, depending on
        /// the number of instances, a small delay might occur.
        ///
        /// When authorizing a user/group pair permission,
        /// GroupName, SourceSecurityGroupName and SourceSecurityGroupOwnerId
        /// must be specified. When authorizing a CIDR IP permission,
        /// GroupName, IpProtocol, FromPort, ToPort and CidrIp must be specified
        /// </remarks>
        /// <param name="request">Authorize Security Group Ingress  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Authorize Security Group Ingress  Response from the service</returns>
        AuthorizeSecurityGroupIngressResponse AuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest request);

        /// <summary>
        /// Bundles an Amazon instance store-backed Windows instance.
        /// This procedure is not applicable for Linux and UNIX instances.
        /// During bundling, only the root device volume (C:\) is bundled. Data on other instance store volumes is not preserved.
        /// </summary>
        /// <param name="request">Bundle Instance  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Bundle Instance  Response from the service</returns>
        BundleInstanceResponse BundleInstance(BundleInstanceRequest request);

        /// <summary>
        /// Cancels a bundling operation for an instance store-backed Windows instance.
        /// </summary>
        /// <param name="request">Cancel Bundle Task  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Cancel Bundle Task  Response from the service</returns>
        CancelBundleTaskResponse CancelBundleTask(CancelBundleTaskRequest request);

        /// <summary>
        /// Determines whether a product code is associated with an instance.
        /// </summary>
        /// <remarks>
        /// This action can only be used by the owner of the product code.
        /// It is useful when a product code owner needs to verify whether another EC2 user’s
        /// instance is eligible for support.
        /// </remarks>
        /// <param name="request">Confirm Product Instance  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Confirm Product Instance  Response from the service</returns>
        ConfirmProductInstanceResponse ConfirmProductInstance(ConfirmProductInstanceRequest request);

        /// <summary>
        /// Creates an AMI that uses an Amazon EBS root device from a "running" or
        /// "stopped" instance. AMIs that use an Amazon EBS root device boot
        /// faster than AMIs that use instance stores. They can be up to 1 TiB in size,
        /// use storage that persists on instance failure, and can be stopped
        /// and started.
        /// </summary>
        /// <param name="request">Create Image  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Image  Response from the service</returns>
        CreateImageResponse CreateImage(CreateImageRequest request);

        /// <summary>
        /// Creates a new 2048-bit RSA key pair with the specified name. The public
        /// key is stored by Amazon EC2 and the private key is returned to you.
        /// </summary>
        /// <remarks>
        /// The private key is returned as an unencrypted PEM encoded PKCS#8 private key.
        /// If a key with the specified name already exists, Amazon EC2 returns an error.
        /// The key pair returned to you works only in the Region you're using when you
        /// create the key pair. To create a key pair that works in all Regions, use ImportKeyPair.
        /// </remarks>
        /// <param name="request">Create Key Pair  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Key Pair  Response from the service</returns>
        CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request);

        /// <summary>
        /// Creates a PlacementGroup into which multiple Amazon EC2
        /// instances can be launched. Users must give the group a
        /// name unique within the scope of the user account.
        /// </summary>
        /// <param name="request">Create Placement Group  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Placement Group  Response from the service</returns>
        CreatePlacementGroupResponse CreatePlacementGroup(CreatePlacementGroupRequest request);

        /// <summary>
        /// Creates a new security group. Group names must be
        /// unique per account.
        /// </summary>
        /// <remarks>
        /// Every instance is launched in a security group.
        /// If no security group is specified during launch,
        /// the instances are launched in the default security group.
        /// Instances within the same security group have unrestricted network
        /// access to each other. Instances will reject network access attempts from
        /// other instances in a different security group. As the owner of instances you
        /// can grant or revoke specific permissions using the
        /// AuthorizeSecurityGroupIngress and RevokeSecurityGroupIngress
        /// operations.
        /// </remarks>
        /// <param name="request">Create Security Group  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Security Group  Response from the service</returns>
        CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request);

        /// <summary>
        /// Creates a snapshot of an Amazon EBS volume and stores it in Amazon S3.
        /// You can use snapshots for backups, to make identical copies of instance
        /// devices, and to save data before shutting down an instance.
        /// </summary>
        /// <remarks>
        /// When taking a snapshot of a file system, we recommend unmounting it
        /// first. This ensures the file system metadata is in a consistent state,
        /// that the 'mounted indicator' is cleared, and that all applications
        /// using that file system are stopped and in a consistent state. Some file
        /// systems, such as xfs, can freeze and unfreeze activity so a
        /// snapshot can be made without unmounting.
        ///
        /// For Linux/UNIX, enter the
        /// following command from the command line.
        ///
        /// umount -d /dev/sdh
        ///
        /// For Windows, open Disk Management, right-click the volume to unmount,
        /// and select Change Drive Letter and Path. Then, select the mount
        /// point to remove and click Remove.
        /// </remarks>
        /// <param name="request">Create Snapshot  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Snapshot  Response from the service</returns>
        CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request);

        /// <summary>
        /// Adds or overwrites tags for the specified resources. 
        /// Each resource can have a maximum of 10 tags. 
        /// Each tag consists of a key-value pair.
        /// Tag keys must be unique per resource.
        /// </summary>
        /// <param name="request">Create Tags  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Tags  Response from the service</returns>
        CreateTagsResponse CreateTags(CreateTagsRequest request);

        /// <summary>
        /// Creates a new Amazon EBS volume that can be attached to any Amazon EC2
        /// instance in the same Availability Zone.
        /// Any AWS Marketplace product codes from the snapshot are propagated to the volume.
        /// </summary>
        /// <param name="request">Create Volume  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Volume  Response from the service</returns>
        CreateVolumeResponse CreateVolume(CreateVolumeRequest request);

        /// <summary>
        /// Deactivates a specific number of licenses.
        /// </summary>
        /// <remarks>
        /// Deactivations can be done against a specific license ID
        /// after they have persisted for at least a 90-day period.
        /// </remarks>
        /// <param name="request">Deactivate License  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Deactivate License  Response from the service</returns>
        DeactivateLicenseResponse DeactivateLicense(DeactivateLicenseRequest request);

        /// <summary>
        /// Deletes the specified key pair, by removing the
        /// public key from Amazon EC2. You must own the key pair.
        /// </summary>
        /// <param name="request">Delete Key Pair  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Key Pair  Response from the service</returns>
        DeleteKeyPairResponse DeleteKeyPair(DeleteKeyPairRequest request);

        /// <summary>
        /// Deletes a PlacementGroupfrom a user's account.
        /// Terminate all Amazon EC2 instances in the placement group before
        /// deletion.
        /// </summary>
        /// <param name="request">Delete Placement Group  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Placement Group  Response from the service</returns>
        DeletePlacementGroupResponse DeletePlacementGroup(DeletePlacementGroupRequest request);

        /// <summary>
        /// Deletes a security group that you own.
        /// </summary>
        ///<remarks>
        /// If you attempt to delete a security group that contains instances, an
        /// error is returned.
        ///
        /// If you attempt to delete a security group that is referenced by
        /// another security group, an error is returned. For example,
        /// if security group B has a rule that allows access from
        /// security group A, security group A cannot be deleted until the
        /// allow rule is removed.
        /// </remarks>
        /// <param name="request">Delete Security Group  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Security Group  Response from the service</returns>
        DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request);

        /// <summary>
        /// Deletes a snapshot of an Amazon EBS volume that you own.
        /// </summary>
        /// <param name="request">Delete Snapshot  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Snapshot  Response from the service</returns>
        DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request);

        /// <summary>
        /// Deletes tags from the specified resources.
        /// </summary>
        /// <param name="request">Delete Tags  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Tags  Response from the service</returns>
        DeleteTagsResponse DeleteTags(DeleteTagsRequest request);

        /// <summary>
        /// Deletes an Amazon EBS volume that you own.
        /// The volume must be in the available state (not attached to an instance).
        /// </summary>
        /// <param name="request">Delete Volume  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Volume  Response from the service</returns>
        DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request);

        /// <summary>
        /// Deregisters the specified AMI. Once deregistered,
        /// the AMI cannot be used to launch new instances.
        /// </summary>
        /// <remarks>
        /// This command does not delete the AMI from Amazon S3.
        /// </remarks>
        /// <param name="request">Deregister Image  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Deregister Image  Response from the service</returns>
        DeregisterImageResponse DeregisterImage(DeregisterImageRequest request);

        /// <summary>
        /// Lists elastic IP addresses assigned to your
        /// account or provides information about a
        /// specific address.
        /// </summary>
        /// <param name="request">Describe Addresses  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Addresses  Response from the service</returns>
        DescribeAddressesResponse DescribeAddresses(DescribeAddressesRequest request);

        /// <summary>
        /// Lists Availability Zones that are currently
        /// available to the account and their states.
        /// </summary>
        /// <remarks>
        /// Availability Zones are not the same across accounts.
        /// The Availability Zone us-east-1a for account A is not
        /// necessarily the same as us-east-1a for account B.
        /// Zone assignments are mapped independently for each account.
        /// </remarks>
        /// <param name="request">Describe Availability Zones  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Availability Zones  Response from the service</returns>
        DescribeAvailabilityZonesResponse DescribeAvailabilityZones(DescribeAvailabilityZonesRequest request);

        /// <summary>
        /// Describes current bundling tasks.
        /// </summary>
        /// <remarks>
        /// Describes in-progress and recent bundle tasks.
        /// Complete and failed tasks are removed from the list a
        /// short time after completion.
        /// If no bundle ids are given, all bundle tasks are returned.
        /// </remarks>
        /// <param name="request">Describe Bundle Tasks  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Bundle Tasks  Response from the service</returns>
        DescribeBundleTasksResponse DescribeBundleTasks(DescribeBundleTasksRequest request);

        /// <summary>
        /// Provides details of a user's registered licenses.
        /// </summary>
        /// <remarks>
        /// Zero or more IDs may be specified on the call.
        /// When one or more license IDs are specified,
        /// only data for the specified IDs are returned.
        /// </remarks>
        /// <param name="request">Describe Licenses  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Licenses  Response from the service</returns>
        DescribeLicensesResponse DescribeLicenses(DescribeLicensesRequest request);

        /// <summary>
        /// Returns information about one or more PlacementGroup instances
        /// in a user's account.
        /// </summary>
        /// <param name="request">Describe Placement Groups  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Placement Groups  Response from the service</returns>
        DescribePlacementGroupsResponse DescribePlacementGroups(DescribePlacementGroupsRequest request);

        /// <summary>
        /// Returns information about an attribute of a snapshot.
        /// Only one attribute can be specified per call.
        /// </summary>
        /// <param name="request">Describe Snapshot Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Snapshot Attribute  Response from the service</returns>
        DescribeSnapshotAttributeResponse DescribeSnapshotAttribute(DescribeSnapshotAttributeRequest request);

        /// <summary>
        /// Gets information about an attribute of an AMI.
        /// Only one attribute can be specified per call.
        /// </summary>
        /// <param name="request">Describe Image Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Image Attribute  Response from the service</returns>
        DescribeImageAttributeResponse DescribeImageAttribute(DescribeImageAttributeRequest request);

        /// <summary>
        /// Returns information about AMIs, AKIs, and ARIs.
        /// This includes image type, product codes, architecture, and kernel
        /// and RAM disk IDs. Images available to you include public images,
        /// private images that you own, and private images owned by other
        /// users for which you have explicit launch permissions.
        /// </summary>
        /// <remarks>
        /// Launch permissions fall into three categories:
        ///
        /// 1. public:
        /// The owner of the AMI granted launch permissions for the AMI to the
        /// all group. All users have launch permissions for these AMIs.
        ///
        /// 2. explicit:
        /// The owner of the AMI granted launch permissions to a specific user.
        ///
        /// 3. implicit:
        /// A user has implicit launch permissions for all AMIs he or she
        /// owns.
        ///
        /// The list of AMIs returned can be modified by specifying AMI IDs,
        /// AMI owners, or users with launch permissions. If no options are
        /// specified, Amazon EC2 returns all AMIs for
        /// which the user has launch permissions.
        ///
        /// If you specify one or more AMI IDs, only AMIs that have the
        /// specified IDs are returned. If you specify an invalid AMI
        /// ID, a fault is returned. If you specify an AMI ID for which
        /// you do not have access, it will not be included in the returned
        /// results.
        ///
        /// If you specify one or more AMI owners, only AMIs from the
        /// specified owners and for which you have access are returned. The
        /// results can include the account IDs of the
        /// specified owners, amazon for AMIs owned by Amazon or self for AMIs that you
        /// own.
        ///
        /// If you specify a list of executable users, only users that have
        /// launch permissions for the AMIs are returned. You can specify account IDs
        /// (if you own the AMI(s)), self for AMIs for which you own or have
        /// explicit permissions, or all for public AMIs.
        /// </remarks>
        /// <param name="request">Describe Images  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Images  Response from the service</returns>
        DescribeImagesResponse DescribeImages(DescribeImagesRequest request);

        /// <summary>
        /// Describes the status of an Amazon Elastic Compute Cloud (Amazon EC2) instance.
        /// Instance status provides information about two types of scheduled events for
        /// an instance that may require your attention, Scheduled Reboot and Scheduled Retirement.
        /// Only information about instances in the running state is returned.
        /// </summary>
        /// <param name="request">Describe Instance Status request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Instance Status response from the service</returns>
        DescribeInstanceStatusResponse DescribeInstanceStatus(DescribeInstanceStatusRequest request);

        /// <summary>
        /// Submits feedback about an instance's status.
        /// </summary>
        /// <remarks>
        /// This action works only for instances that are in the running state.
        /// If your experience with the instance differs from the instance status returned by the 
        /// DescribeInstanceStatus action, use ReportInstanceStatus to report your experience with the instance. 
        /// Amazon EC2 collects this information to improve the accuracy of status checks. 
        /// Use of this action does not change the value returned by DescribeInstanceStatus.
        /// </remarks>
        /// <param name="request">Report Instance Status request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Report Instance Status response from the service</returns>
        ReportInstanceStatusResponse ReportInstanceStatus(ReportInstanceStatusRequest request);

        /// <summary>
        /// Returns information about instances that you own.
        /// </summary>
        /// <remarks>
        /// If you specify one or more instance IDs, Amazon EC2 returns
        /// information for those instances.
        ///
        /// If you do not specify instance IDs, Amazon EC2 returns information
        /// for all relevant instances. If you
        /// specify an invalid instance ID, a fault is returned.
        ///
        /// If you specify an instance that you do not own, it will not be
        /// included in the returned results.
        ///
        /// Recently terminated instances might appear in the returned results.This
        /// interval is usually less than one hour.
        /// </remarks>
        /// <param name="request">Describe Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Instances  Response from the service</returns>
        DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request);

        /// <summary>
        /// Describes regions that are currently available to
        /// the account.
        /// </summary>
        /// <param name="request">Describe Regions  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Regions  Response from the service</returns>
        DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request);

        /// <summary>
        /// Describes Reserved Instances that you purchased.
        /// </summary>
        /// <remarks>
        /// For more information about Reserved Instances, go to the
        /// Amazon Elastic Compute Cloud Developer Guide.
        /// </remarks>
        /// <param name="request">Describe Reserved Instances  request</param>
        /// <returns>Describe Reserved Instances  Response from the service</returns>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        DescribeReservedInstancesResponse DescribeReservedInstances(DescribeReservedInstancesRequest request);

        /// <summary>
        /// Describes Reserved Instance offerings that are available for purchase.
        /// </summary>
        /// <remarks>
        /// With Amazon EC2 Reserved Instances, you purchase the right to launch
        /// Amazon EC2 instances for a period of time (without getting insufficient
        /// capacity errors) and pay a lower usage rate for the actual time used.
        /// For more information about Reserved Instances, go to the Amazon
        /// Elastic Compute Cloud Developer Guide.
        /// </remarks>
        /// <param name="request">Describe Reserved Instances Offerings  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Reserved Instances Offerings  Response from the service</returns>
        DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest request);

        /// <summary>
        /// Returns information about key pairs available to
        /// you. If you specify key pairs, information
        /// about those key pairs is returned. Otherwise, information for all
        /// registered key pairs is returned.
        /// </summary>
        /// <param name="request">Describe Key Pairs  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Key Pairs  Response from the service</returns>
        DescribeKeyPairsResponse DescribeKeyPairs(DescribeKeyPairsRequest request);

        /// <summary>
        /// Returns information about security groups that you own.
        /// </summary>
        /// <remarks>
        /// If you specify security group names, information about those security
        /// group is returned. Otherwise, information for all security group is
        /// returned.
        /// If you specify a group that does not exist, a fault is returned.
        /// </remarks>
        /// <param name="request">Describe Security Groups  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Security Groups  Response from the service</returns>
        DescribeSecurityGroupsResponse DescribeSecurityGroups(DescribeSecurityGroupsRequest request);

        /// <summary>
        /// Returns information about Amazon EBS snapshots available to the user.
        /// </summary>
        /// <remarks>
        /// Information returned includes volume ID, status, start time, progress,
        /// owner ID, volume size, and description. Snapshots available to the user
        /// include public snapshots available for any user to launch, private
        /// snapshots owned by the user making the request, and private snapshots
        /// owned by other users for which the user granted explicit create
        /// volume permissions.
        ///
        /// The create volume permissions fall into 3 categories:
        ///
        /// public
        ///
        /// The owner of the snapshot granted create volume permissions for the
        /// snapshot to the all group. All users have create volume permissions
        /// for these snapshots.
        ///
        /// explicit
        ///
        /// The owner of the snapshot granted create volume permissions to a
        /// specific user.
        ///
        /// implicit
        ///
        /// A user has implicit create volume permissions for all snapshots he
        /// or she owns.
        ///
        /// The list of snapshots returned can be modified by specifying
        /// snapshot IDs, snapshot owners, or users with create volume permissions.
        ///
        /// If no options are specified, Amazon EC2 returns all snapshots for
        /// which the user has create volume permissions.
        ///
        /// If you specify one or more snapshot IDs, only snapshots that have
        /// the specified IDs are returned. If you specify an invalid snapshot ID,
        /// a fault is returned. If you specify a snapshot ID for which you do not
        /// have access, it will not be included in the returned results.
        ///
        /// If you specify one or more snapshot owners, only snapshots from the
        /// specified owners and for which you have access are returned. The
        /// results can include the AWS Account IDs of the specified owners,
        /// amazon for snapshots owned by Amazon or self for snapshots that you own.
        ///
        /// If you specify a list of restorable users, only users that
        /// have create snapshot permissions for the snapshots are returned.
        /// You can specify AWS Account IDs (if you own the snapshot(s)), self for
        /// snapshots for which you own or have explicit permissions, or all for
        /// public snapshots.
        /// </remarks>
        /// <param name="request">Describe Snapshots  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Snapshots  Response from the service</returns>
        DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request);

        /// <summary>
        /// Describes Tags for the specified resources.
        /// </summary>
        /// <param name="request">Describe Tags  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Tags  Response from the service</returns>
        DescribeTagsResponse DescribeTags(DescribeTagsRequest request);

        /// <summary>
        /// Describes the specified Amazon EBS volumes that you own.
        /// </summary>
        /// <remarks>
        /// If you do not specify one or more volume IDs, Amazon EBS
        /// describes all volumes that you own.
        /// For more information about Amazon EBS, go to the Amazon
        /// Elastic Compute Cloud Developer Guide.
        /// </remarks>
        /// <param name="request">Describe Volumes  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Volumes  Response from the service</returns>
        DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request);

        /// <summary>
        /// Detaches an Amazon EBS volume from an instance.
        /// </summary>
        /// <remarks>
        /// For more information about Amazon EBS, go
        /// to the Amazon Elastic Compute Cloud Developer Guide.
        ///
        /// Important - make sure to unmount any file systems
        /// on the device within your operating system before
        /// detaching the volume.
        ///
        /// Failure to unmount file systems, or otherwise
        /// properly release the device from use, can result
        /// in lost data and will corrupt the file system.
        /// </remarks>
        /// <param name="request">Detach Volume  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Detach Volume  Response from the service</returns>
        DetachVolumeResponse DetachVolume(DetachVolumeRequest request);

        /// <summary>
        /// Disassociates the specified elastic IP address
        /// from the instance to which it is assigned.
        /// </summary>
        /// <remarks>
        /// This is an idempotent operation. If you call it more
        /// than once, Amazon EC2 does not return an error.
        /// </remarks>
        /// <param name="request">Disassociate Address  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Disassociate Address  Response from the service</returns>
        DisassociateAddressResponse DisassociateAddress(DisassociateAddressRequest request);

        /// <summary>
        /// Retrieves the encrypted administrator password for the instances running Windows.
        /// </summary>
        /// <remarks>
        /// The Windows password is only generated the first time an AMI is launched.
        /// It is not generated for rebundled AMIs or after the password is
        /// changed on an instance.
        /// The password is encrypted using the key pair that you
        /// provided.
        /// </remarks>
        /// <param name="request">Get Password Data  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Get Password Data  Response from the service</returns>
        GetPasswordDataResponse GetPasswordData(GetPasswordDataRequest request);

        /// <summary>
        /// Retrieves console output for the specified instance.
        /// </summary>
        /// <remarks>
        /// Instance console output is buffered and posted shortly
        /// after instance boot, reboot, and termination.
        /// Amazon EC2 preserves the most recent 64 KB output which
        /// will be available for at least one hour after the most
        /// recent post.
        /// </remarks>
        /// <param name="request">Get Console Output  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Get Console Output  Response from the service</returns>
        GetConsoleOutputResponse GetConsoleOutput(GetConsoleOutputRequest request);

        /// <summary>
        /// Imports the public key from an RSA key pair created with a third-party tool.
        /// </summary>
        /// <remarks>
        /// This operation differs from CreateKeyPair as the private key is never
        /// transferred between the caller and AWS servers.
        ///
        /// RSA key pairs are easily created on Microsoft Windows and Linux OS systems using
        /// the ssh-keygen command line tool provided with the standard OpenSSH
        /// installation. Standard library support for RSA key pair creation is also available
        /// for Java, Ruby, Python, and many other programming languages.
        ///
        /// The following formats are supported:
        /// - OpenSSH public key format,
        /// - Base64 encoded DER format.
        /// - SSH public key file format as specified in RFC4716.
        /// </remarks>
        /// <param name="request">Import Key Pair  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Import Key Pair  Response from the service</returns>
        ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request);

        /// <summary>
        /// Adds or remove permission settings for the specified snapshot
        /// </summary>
        /// <param name="request">Modify Snapshot Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Modify Snapshot Attribute  Response from the service</returns>
        ModifySnapshotAttributeResponse ModifySnapshotAttribute(ModifySnapshotAttributeRequest request);

        /// <summary>
        /// Modifies an attribute of an AMI
        /// </summary>
        /// <param name="request">Modify Image Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Modify Image Attribute  Response from the service</returns>
        ModifyImageAttributeResponse ModifyImageAttribute(ModifyImageAttributeRequest request);

        /// <summary>
        /// Purchases a Reserved Instance for use with your account.
        /// </summary>
        /// <remarks>
        /// With Amazon EC2 Reserved Instances, you purchase the right
        /// to launch Amazon EC2 instances for a period of time (without
        /// getting insufficient capacity errors) and pay a lower usage rate for
        /// the actual time used.
        /// 
        /// For more information about Reserved Instances, go to the Amazon
        /// Elastic Compute Cloud Developer Guide.
        /// </remarks>
        /// <param name="request">Purchase Reserved Instances Offering  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Purchase Reserved Instances Offering  Response from the service</returns>
        PurchaseReservedInstancesOfferingResponse PurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest request);

        /// <summary>
        /// Requests a reboot of one or more instances.
        /// </summary>
        /// <remarks>
        /// This operation is asynchronous; it only queues a request to
        /// reboot the specified instance(s). The operation will succeed if the instances
        /// are valid and belong to you. Requests to reboot terminated instances
        /// are ignored.
        ///
        /// Note - if a Linux/UNIX instance does not cleanly shut
        /// down within four minutes, Amazon EC2 will perform a hard reboot.
        /// </remarks>
        /// <param name="request">Reboot Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Reboot Instances  Response from the service</returns>
        RebootInstancesResponse RebootInstances(RebootInstancesRequest request);

        /// <summary>
        /// Registers an AMI with Amazon EC2.
        /// </summary>
        /// <remarks>
        /// Images must be registered before they can be launched.
        /// To launch instances, use the RunInstances operation.
        ///
        /// Each AMI is associated with an unique ID which is provided by
        /// the Amazon EC2 service through the RegisterImage operation.
        /// During registration, Amazon EC2 retrieves the specified image
        /// manifest from Amazon S3 and verifies that the image is owned
        /// by the user registering the image.
        ///
        /// The image manifest is retrieved once and stored within the Amazon
        /// EC2. Any modifications to an image in Amazon S3 invalidates this
        /// registration. If you make changes to an image, deregister the
        /// previous image and register the new image. To deregister an image,
        /// use the DeregisterImage operation.
        /// </remarks>
        /// <param name="request">Register Image  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Register Image  Response from the service</returns>
        RegisterImageResponse RegisterImage(RegisterImageRequest request);

        /// <summary>
        /// Releases an elastic IP address associated with your account.
        /// </summary>
        ///<remarks>
        /// If you run this operation on an elastic IP address that is
        /// already released, the address might be assigned to another
        /// account which will cause Amazon EC2 to return an error.
        ///
        /// Releasing an IP address automatically disassociates it from any
        /// instance with which it is associated. To disassociate an IP
        /// address without releasing it, use the DisassociateAddress
        /// operation.
        ///
        /// After releasing an elastic IP address, it is
        /// released to the IP // address pool and might no longer be
        /// available to your account. Make sure to update your DNS
        /// records and any servers or devices that communicate with
        /// the address.
        /// </remarks>
        /// <param name="request">Release Address  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Release Address  Response from the service</returns>
        ReleaseAddressResponse ReleaseAddress(ReleaseAddressRequest request);

        /// <summary>
        /// Resets permission settings for the specified snapshot
        /// </summary>
        /// <param name="request">Reset Snapshot Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Reset Snapshot Attribute  Response from the service</returns>
        ResetSnapshotAttributeResponse ResetSnapshotAttribute(ResetSnapshotAttributeRequest request);

        /// <summary>
        /// Resets an attribute of an AMI to its default value.
        /// Note - The productCodes attribute cannot be reset.
        /// </summary>
        /// <param name="request">Reset Image Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Reset Image Attribute  Response from the service</returns>
        ResetImageAttributeResponse ResetImageAttribute(ResetImageAttributeRequest request);

        /// <summary>
        /// Revokes permissions from a security group.
        /// </summary>
        /// <remarks>
        /// The permissions used to revoke must be specified using the same values
        /// used to grant the permissions.
        ///
        /// Permissions are specified by IP protocol (TCP, UDP, or ICMP), the source
        /// of the request (by IP range or an Amazon EC2 user-group pair), the
        /// source and destination port ranges (for TCP and UDP), and the ICMP codes
        /// and types (for ICMP).
        ///
        /// Permission changes are quickly propagated to instances within the
        /// security group. However, depending on the number of instances in the group,
        /// a small delay is might occur.
        /// </remarks>
        /// <param name="request">Revoke Security Group Ingress  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Revoke Security Group Ingress  Response from the service</returns>
        RevokeSecurityGroupIngressResponse RevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request);

        /// <summary>
        /// Launches a specified number of instances of an AMI for which you have permissions.
        /// </summary>
        /// <remarks>
        /// If Amazon EC2 cannot launch the minimum number AMIs you request, no
        /// instances will be launched. If there is insufficient capacity to
        /// launch the maximum number of AMIs you request, Amazon EC2 launches the minimum
        /// number specified for each AMI and allocate the remaining available
        /// instances using round robin.
        ///
        /// In the following example, Libby generates a request to
        /// launch two images (database and web_server):
        ///
        /// Libby runs the RunInstances operation to launch database instances
        /// (min. 10, max. 15) and web_server instances (min. 30, max. 40).
        ///
        /// Because there are currently 30 instances available and Libby needs a
        /// minimum of 40, no instances are launched.
        ///
        /// Libby adjusts the number of instances she needs and runs the
        /// RunInstances operation to launch database
        /// instances (min. 5, max. 10) and web_server
        /// instances (min. 20, max. 40).
        ///
        /// Amazon EC2 launches the minimum number of instances for each
        /// AMI (5 database, 20 web_server).
        ///
        /// The remaining 5 instances are allocated using round robin.
        ///
        /// Libby adjusts the number of instances she needs and runs the RunInstances
        /// operation again to launch database instances (min. 5, max. 10) and
        /// web_server instances (min. 20, max. 40).
        ///
        /// Note - every instance is launched in a security group
        /// (created using the CreateSecurityGroup operation.)
        ///
        /// You can provide an optional key pair ID for each image in the launch request
        /// (created using the CreateKeyPair operation). All instances that
        /// are created from images that use this key pair will have access to
        /// the associated public key at boot. You can use this key to provide
        /// secure access to an instance of an image on a per-instance basis.
        /// Amazon EC2 public images use this feature to provide secure access
        /// without passwords.
        ///
        /// Important - launching public images without a key pair ID will leave them
        /// inaccessible.
        ///
        /// The public key material is made available to the instance at boot
        /// time by placing it in the openssh_id.pub file on a logical device that is exposed
        /// to the instance as /dev/sda2 (the instance store). The format of this
        /// file is suitable for use as an entry within ~/.ssh/authorized_keys
        /// (the OpenSSH format). This can be done at boot (e.g., as part of rc.local) allowing
        /// for secure access without passwords.
        ///
        /// Optional user data can be provided in the launch request. All instances that
        /// collectively comprise the launch request have access to this data.
        /// For more information, go the Amazon Elastic Compute Cloud Developer
        /// Guide.
        ///
        /// Note - if any of the AMIs have a product code attached for
        /// which the user has not subscribed, the RunInstances call will fail.
        ///
        /// Important - we strongly recommend using the 2.6.18 Xen stock
        /// kernel with High-CPU and High-Memory instances. Although the
        /// default Amazon EC2 kernels will work, the new kernels provide
        /// greater stability and performance for these instance types. For more
        /// information about kernels, go the Amazon Elastic Compute Cloud Developer Guide
        /// </remarks>
        /// <param name="request">Run Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Run Instances  Response from the service</returns>
        RunInstancesResponse RunInstances(RunInstancesRequest request);

        /// <summary>
        /// Stops an Amazon EBS-backed instance.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Each time you transition an instance from stopped to started,
        /// we charge a full instance hour, even if transitions happen multiple
        /// times within a single hour.
        /// </para>
        /// <para>
        /// Although Spot Instances can use Amazon EBS-backed AMIs, they don't
        /// support Stop/Start. In other words, you can't stop and start Spot
        /// Instances launched from an AMI with an Amazon EBS root device.
        /// </para>
        /// <para>
        /// Instances that use Amazon EBS volumes as their root devices can be
        /// quickly stopped and started. When an instance is stopped, the compute
        /// resources are released and you are not billed for hourly instance usage.
        /// However, your root partition Amazon EBS volume remains, continues to
        /// persist your data, and you are charged for Amazon EBS volume usage.
        /// You can restart your instance at any time.
        /// </para>
        /// <para>
        /// Before stopping an instance, make sure it is in a state from which it
        /// can be restarted. Stopping an instance does not preserve data stored
        /// in RAM. Performing this operation on an instance that uses an instance
        /// store as its root device returns an error.
        /// </para>
        /// <para>
        /// You can stop, start, and terminate EBS-backed instances. You can only
        /// terminate S3-backed instances. What happens to an instance differs
        /// if you stop it or terminate it. For example, when you stop an instance,
        /// the root device and any other devices attached to the instance persist.
        /// When you terminate an instance, the root device and any other devices
        /// attached during the instance launch are automatically deleted.
        /// </para>
        /// </remarks>
        /// <param name="request">Stop Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Stop Instances  Response from the service</returns>
        StopInstancesResponse StopInstances(StopInstancesRequest request);

        /// <summary>
        /// Starts an Amazon EBS-backed AMI that you've previously stopped.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instances that use Amazon EBS volumes as their root devices can be quickly
        /// stopped and started. When an instance is stopped, the compute resources are
        /// released and you are not billed for hourly instance usage. However, your
        /// root partition Amazon EBS volume remains, continues to persist your data, and
        /// you are charged for Amazon EBS volume usage. You can restart your instance
        /// at any time. Each time you transition an instance from stopped to started,
        /// we charge a full instance hour, even if transitions happen multiple times
        /// within a single hour.
        /// </para>
        /// <para>
        /// Before stopping an instance, make sure it is in a state from which it can
        /// be restarted. Stopping an instance does not preserve data stored in RAM.
        /// </para>
        /// <para>
        /// Performing this operation on an instance that uses an instance store as its root device returns
        /// an error.
        /// </para>
        /// </remarks>
        /// <param name="request">Start Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Start Instances  Response from the service</returns>
        StartInstancesResponse StartInstances(StartInstancesRequest request);

        /// <summary>
        /// Modifies an attribute of an instance.
        /// </summary>
        /// <param name="request">Modify Instance Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Modify Instance Attribute  Response from the service</returns>
        ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest request);

        /// <summary>
        /// Resets an attribute of an instance to its default value.
        /// </summary>
        /// <param name="request">Reset Instance Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Reset Instance Attribute  Response from the service</returns>
        ResetInstanceAttributeResponse ResetInstanceAttribute(ResetInstanceAttributeRequest request);

        /// <summary>
        /// Gets information about an attribute of an instance.
        /// Only one attribute can be specified per call.
        /// </summary>
        /// <param name="request">Describe Instance Attribute  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Instance Attribute  Response from the service</returns>
        DescribeInstanceAttributeResponse DescribeInstanceAttribute(DescribeInstanceAttributeRequest request);

        /// <summary>
        /// Shuts down one or more instances.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This operation is idempotent; if you terminate an instance more than
        /// once, each call will succeed. Terminated instances will remain visible
        /// after termination (approximately one hour).
        /// </para>
        /// <para>
        /// By default, Amazon EC2 deletes all Amazon EBS volumes that were attached
        /// when the instance launched. Amazon EBS volumes attached after instance
        /// launch continue running.
        /// </para>
        /// <para>
        /// You can stop, start, and terminate EBS-backed instances. You can only
        /// terminate S3-backed instances. What happens to an instance differs if
        /// you stop it or terminate it. For example, when you stop an instance,
        /// the root device and any other devices attached to the instance persist.
        /// When you terminate an instance, the root device and any other devices
        /// attached during the instance launch are automatically deleted.
        /// </para>
        /// </remarks>
        /// <param name="request">Terminate Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Terminate Instances  Response from the service</returns>
        TerminateInstancesResponse TerminateInstances(TerminateInstancesRequest request);

        /// <summary>
        /// Enables monitoring for a running instance.
        /// </summary>
        /// <param name="request">Monitor Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Monitor Instances  Response from the service</returns>
        MonitorInstancesResponse MonitorInstances(MonitorInstancesRequest request);

        /// <summary>
        /// Disables monitoring for a running instance.
        /// </summary>
        /// <param name="request">Unmonitor Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Unmonitor Instances  Response from the service</returns>
        UnmonitorInstancesResponse UnmonitorInstances(UnmonitorInstancesRequest request);

        /// <summary>
        /// Gives you information about your VPN connections.
        ///
        /// Important - we strongly recommend you use HTTPS when calling this
        /// operation because the response contains sensitive cryptographic
        /// information for configuring your customer gateway.
        ///
        /// You can filter the results to return information only about VPN
        /// connections that match criteria you specify.
        ///
        /// For example, you could ask to get information about a particular VPN
        /// connection (or all) only if the VPN's state is pending or available.
        ///
        /// You can specify multiple filters (e.g., the VPN connection is
        /// associated with a particular VPN gateway, and
        /// the gateway's state is pending or available).
        ///
        /// The result includes information for a particular VPN connection
        /// only if the VPN connection matches all your filters.
        ///
        /// If there's no match, no special message is returned; the response is
        /// simply empty.
        ///
        /// The returned information consists of:
        /// 1. The VPN connection ID.
        /// 2. The type of connection.
        /// 3. Customer gateway ID.
        /// 4. VPN gateway ID.
        /// 5. The current state of the VPN connection (pending, available,
        /// deleting, deleted).
        /// 6. The customer gateway configuration information in the
        /// native XML format.
        /// </summary>
        /// <param name="request">Describe Vpn Connections  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Vpn Connections  Response from the service</returns>
        DescribeVpnConnectionsResponse DescribeVpnConnections(DescribeVpnConnectionsRequest request);

        /// <summary>
        /// Gives you information about your subnets.
        /// </summary>
        /// <remarks>
        /// You can filter the results to return information only about
        /// subnets that match criteria you specify.
        /// For example, you could ask to get information about a particular
        /// subnet (or all) only if the subnet's state is available.
        /// You can specify multiple filters (e.g., the subnet is in a
        /// particular VPC, and the subnet's state is available).
        ///
        /// The result includes information for a particular subnet
        /// only if the subnet matches all your filters. If there's
        /// no match, no special message is returned; the response
        /// is simply empty
        /// </remarks>
        /// <param name="request">Describe Subnets  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Subnets  Response from the service</returns>
        DescribeSubnetsResponse DescribeSubnets(DescribeSubnetsRequest request);

        /// <summary>
        /// Detaches a VPN gateway from a VPC.
        /// </summary>
        /// <remarks>
        /// You do this if you're planning to turn off the VPC and
        /// not use it anymore. You can confirm a VPN gateway has
        /// been completely detached from a VPC by describing the
        /// VPN gateway (any attachments to the VPN gateway are
        /// also described).
        ///
        /// You must wait for the attachment's state to switch
        /// to detached before you can delete the VPC
        /// or attach a different VPC to the VPN gateway.
        /// </remarks>
        /// <param name="request">Detach Vpn Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Detach Vpn Gateway  Response from the service</returns>
        DetachVpnGatewayResponse DetachVpnGateway(DetachVpnGatewayRequest request);

        /// <summary>
        /// Gives you information about your VPCs.
        /// </summary>
        /// <remarks>
        /// You can filter the results to return information only
        /// about VPCs that match criteria you specify.
        ///
        /// For example, you could ask to get information about a
        /// particular VPC or VPCs (or all your VPCs) only if the
        /// VPC's state is available.
        ///
        /// You can specify multiple filters (e.g., the VPC uses
        /// one of several sets of DHCP options, and the VPC's
        /// state is available).
        ///
        /// The result includes information for a particular VPC
        /// only if the VPC matches all your filters.
        ///
        /// If there's no match, no special message is returned;
        /// the response is simply empty.
        ///
        /// The information returned consists of:
        /// a) The VPC ID.
        /// b) The CIDR block
        /// you've assigned to the VPC.
        /// c) The ID of the DHCP options you've associated with the VPC
        /// (or "default" if the default options are associated with the VPC)
        ///
        /// The current state of the VPC (pending or available)
        /// </remarks>
        /// <param name="request">Describe Vpcs  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Vpcs  Response from the service</returns>
        DescribeVpcsResponse DescribeVpcs(DescribeVpcsRequest request);

        /// <summary>
        /// Deletes a customer gateway.
        /// </summary>
        /// <remarks>
        /// You must delete the VPN connection before deleting
        /// the customer gateway.
        ///
        /// AWS might delete any customer gateway if you leave
        /// it inactive for an extended period of time (inactive
        /// means that there's no VPN connection in use with the
        /// customer gateway).
        /// </remarks>
        /// <param name="request">Delete Customer Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Customer Gateway  Response from the service</returns>
        DeleteCustomerGatewayResponse DeleteCustomerGateway(DeleteCustomerGatewayRequest request);

        /// <summary>
        /// Attaches a virtual private gateway to a VPC.
        /// </summary>
        /// <remarks>
        /// This is the last step required to get your VPC fully connected
        /// to your data center before launching instances in it.
        /// </remarks>
        /// <param name="request">Attach Vpn Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Attach Vpn Gateway  Response from the service</returns>
        AttachVpnGatewayResponse AttachVpnGateway(AttachVpnGatewayRequest request);

        /// <summary>
        /// Deletes a set of DHCP options that you specify.
        /// </summary>
        /// <remarks>
        /// Amazon VPC returns an error if the set of options
        /// you specify is currently associated with a VPC.
        /// You can disassociate the set of options by associating
        /// either a new set of options or the default options
        /// with the VPC.
        /// </remarks>
        /// <param name="request">Delete Dhcp Options  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Dhcp Options  Response from the service</returns>
        DeleteDhcpOptionsResponse DeleteDhcpOptions(DeleteDhcpOptionsRequest request);

        /// <summary>
        /// Deletes a subnet from a VPC.
        /// </summary>
        /// <remarks>
        /// You must terminate all running instances in the subnet
        /// before deleting it, otherwise Amazon VPC returns an error.
        ///
        /// AWS might delete any subnet if you leave it inactive for
        /// an extended period of time (inactive means that there are
        /// no running Amazon EC2 instances in the subnet).
        /// </remarks>
        /// <param name="request">Delete Subnet  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Subnet  Response from the service</returns>
        DeleteSubnetResponse DeleteSubnet(DeleteSubnetRequest request);

        /// <summary>
        /// Creates a VPC with the CIDR block you specify.
        /// </summary>
        /// <remarks>
        /// The smallest VPC you can create uses a /28 netmask (16 IP
        /// addresses), and the largest uses a /18 netmask (16,384 IP addresses).
        /// To help you decide how big to make your VPC, go to the
        /// topic about creating VPCs in the Amazon Virtual Private Cloud
        /// Developer Guide.
        ///
        /// By default, each instance you launch in the VPC has the default DHCP
        /// options (the standard EC2 host name, no domain name, no DNS server, no NTP
        /// server, and no NetBIOS server or node type).
        ///
        /// AWS might delete any VPC that you create with this operation
        /// if you leave it inactive for an extended period of time (inactive
        /// means that there are no running Amazon EC2 instances in the VPC).
        /// </remarks>
        /// <param name="request">Create Vpc  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Vpc  Response from the service</returns>
        CreateVpcResponse CreateVpc(CreateVpcRequest request);

        /// <summary>
        /// Provides information to AWS about your customer gateway device.
        /// </summary>
        /// <remarks>
        /// The customer gateway is the appliance at your end of the VPN connection
        /// (compared to the VPN gateway, which is the device at the AWS side of the
        /// VPN connection). AWS might delete any customer gateway that you create
        /// with this operation if you leave it inactive for an extended period of
        /// time (inactive means that there's no VPN connection in use with the customer
        /// gateway).
        ///
        /// You must provide the Internet-routable IP address of the customer
        /// gateway's external interface. The IP address must be static and can't be
        /// behind a device performing network address translation (NAT).
        ///
        /// For device’s that use Border Gateway Protocal (BGP), you can also provide the 
        /// device's Border Gateway Protocol (BGP) Autonomous System Number (ASN). You can 
        /// use an existing ASN assigned to your network. If you don't have an ASN already, 
        /// you can use a private ASN (in the 64512 - 65534 range).
        /// 
        /// Amazon EC2 supports all 2-byte ASN numbers in the range of 1 - 65534, with the 
        /// exception of 7224, which is reserved in US East, and 9059, which is reserved in 
        /// EU West
        /// 
        /// For more information about ASNs, go to the Wikipedia article -
        /// http://en.wikipedia.org/wiki/Autonomous_system_%28Internet%29.
        /// </remarks>
        /// <param name="request">Create Customer Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Customer Gateway  Response from the service</returns>
        CreateCustomerGatewayResponse CreateCustomerGateway(CreateCustomerGatewayRequest request);

        /// <summary>
        /// Creates a new VPN gateway.
        /// </summary>
        /// <remarks>
        /// A VPN gateway is the VPC-side endpoint for your VPN
        /// connection. You can create a VPN gateway before
        /// creating the VPC itself. AWS might delete any VPN
        /// gateway that you create with this operation if you leave
        /// it inactive for an extended period of time (inactive means that
        /// there's no VPN connection in use with the VPN gateway)
        /// </remarks>
        /// <param name="request">Create Vpn Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Vpn Gateway  Response from the service</returns>
        CreateVpnGatewayResponse CreateVpnGateway(CreateVpnGatewayRequest request);

        /// <summary>
        /// Deletes a VPC.
        /// </summary>
        /// <remarks>
        /// You must terminate all running instances and delete
        /// all subnets before deleting the VPC, otherwise Amazon
        /// VPC returns an error.
        ///
        /// AWS might delete any VPC if you leave it inactive for
        /// an extended period of time (inactive means that there
        /// are no running Amazon EC2 instances in the VPC).
        /// </remarks>
        /// <param name="request">Delete Vpc  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Vpc  Response from the service</returns>
        DeleteVpcResponse DeleteVpc(DeleteVpcRequest request);

        /// <summary>
        /// Associates a set of DHCP options (that you've previously created) with the
        /// specified VPC. Or, associates the default DHCP options with the VPC.
        /// </summary>
        /// <remarks>
        /// The default set consists of the standard EC2 host name, no domain name, no
        /// DNS server, no NTP server, and no NetBIOS server or node type.
        ///
        /// After you associate the options with the VPC, any existing instances
        /// and all new instances that you launch in that VPC use the options. For more
        /// information about the supported DHCP options and using them with
        /// Amazon VPC, go to Using DHCP Options in the Amazon Virtual Private Cloud
        /// Developer Guide.
        /// </remarks>
        /// <param name="request">Associate Dhcp Options  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Associate Dhcp Options  Response from the service</returns>
        AssociateDhcpOptionsResponse AssociateDhcpOptions(AssociateDhcpOptionsRequest request);

        /// <summary>
        /// Gives you information about your VPN gateways.
        /// </summary>
        /// <remarks>
        /// You can filter the results to return information
        /// only about VPN gateways that match criteria you specify. For example,
        /// you could ask to get information about a particular VPN gateway (or all) only
        /// if the gateway's state is pending or available. You can specify
        /// multiple filters (e.g., the VPN gateway is in a particular
        /// Availability Zone and the gateway's state is pending or available).
        /// The result includes information for a particular VPN gateway only if
        /// the gateway matches all your filters. If there's no match, no
        /// special message is returned; the response is simply empty.
        ///
        /// The returned information consists of:
        ///
        /// 1. The VPN gateway ID - The current state of the VPN gateway
        /// (pending, available, deleting, deleted)
        /// 2. The type of VPN connection the VPN gateway supports.
        /// 3. The Availability Zone where the VPN gateway was created.
        /// 4. The VPCs the VPN gateway is attached to and the state of each
        /// attachment (attaching, attached, detaching, detached)
        /// </remarks>
        /// <param name="request">Describe Vpn Gateways  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Vpn Gateways  Response from the service</returns>
        DescribeVpnGatewaysResponse DescribeVpnGateways(DescribeVpnGatewaysRequest request);

        /// <summary>
        /// Creates a subnet in an existing VPC.
        /// </summary>
        /// <remarks>
        /// You can create up to 20 subnets in a VPC. If you add more than one subnet to a
        /// VPC, they're set up in a star topology with a logical router in the middle.
        /// If you feel you need more than 20 subnets, you can request more by going
        /// to http://aws.amazon.com/contact-us/vpc-request/.
        /// 
        /// When you create each subnet, you provide the VPC ID and the CIDR block you
        /// want for the subnet. Once you create a subnet, you can't change its CIDR block.
        /// The subnet's CIDR block can be the same as the VPC's CIDR block (assuming you
        /// want only a single subnet in the VPC), or a subset of the VPC's CIDR block. If you
        /// create more than one subnet in a VPC, the subnets' CIDR blocks must not overlap.
        /// The smallest subnet (and VPC) you can create uses a /28 netmask (16 IP
        /// addresses), and the largest uses a /18 netmask (16,384 IP addresses).
        ///
        /// *Important*
        ///
        /// AWS reserves both the first four and the last IP address in each subnet's CIDR block.
        /// They're not available for use.
        ///
        /// AWS might delete any subnet you create with this operation if you leave it inactive
        /// for an extended period of time (inactive means that there are no running Amazon
        /// EC2 instances in the subnet).
        /// </remarks>
        /// <param name="request">Create Subnet  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Subnet  Response from the service</returns>
        CreateSubnetResponse CreateSubnet(CreateSubnetRequest request);

        /// <summary>
        /// Deletes a VPN connection.
        /// </summary>
        /// <remarks>
        /// This operation will delete a VPC and all its associated components.
        /// Another reason to use this operation is if you believe the tunnel
        /// credentials for your VPN connection have been compromised.
        ///
        /// In that situation, you can delete the VPN connection and create a
        /// new one that has new keys, without needing to delete
        /// the VPC or VPN gateway. If you create a new VPN
        /// connection, you must reconfigure the customer
        /// gateway using the new configuration information returned
        /// with the new VPN connection ID.
        ///
        /// If you're deleting the VPC and all its associated parts, we
        /// recommend you detach the VPN gateway from the
        /// VPC and delete the VPC before deleting the VPN
        /// connection.
        /// </remarks>
        /// <param name="request">Delete Vpn Connection  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Vpn Connection  Response from the service</returns>
        DeleteVpnConnectionResponse DeleteVpnConnection(DeleteVpnConnectionRequest request);

        /// <summary>
        /// Deletes a VPN gateway.
        /// </summary>
        /// <remarks>
        /// Use this when you want to delete a VPC and all its
        /// associated components because you no longer need them. We recommend
        /// that before you delete a VPN gateway, you detach it from the VPC
        /// and delete the VPN connection. Note that you don't need to delete
        /// the VPN gateway if you just want to delete and re-create the VPN
        /// connection between your VPC and data center.
        ///
        /// AWS might delete any VPN gateway if you leave it inactive for an
        /// extended period of time (inactive means that there's no VPN
        /// connection in use with the VPN gateway).
        /// </remarks>
        /// <param name="request">Delete Vpn Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Vpn Gateway  Response from the service</returns>
        DeleteVpnGatewayResponse DeleteVpnGateway(DeleteVpnGatewayRequest request);

        /// <summary>
        /// Returns information about your customer gateways.
        /// </summary>
        /// <remarks>
        /// You can filter the results to return information only about customer gateways
        /// that match criteria you specify.
        /// 
        /// For example, you could ask to get information about a particular
        /// customer gateway (or all) only if the gateway's state is pending or
        /// available. You can specify multiple filters (e.g., the customer
        /// gateway has a particular IP address for the Internet-routable
        /// external interface, and the gateway's state is pending or
        /// available). The result includes information for a particular
        /// customer gateway only if the gateway matches all your
        /// filters. If there's no match, no special message is returned;
        /// the response is simply empty
        /// </remarks>
        /// <param name="request">Describe Customer Gateways  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Customer Gateways  Response from the service</returns>
        DescribeCustomerGatewaysResponse DescribeCustomerGateways(DescribeCustomerGatewaysRequest request);

        /// <summary>
        /// Creates a VPN connection between an existing virtual private gateway and a VPN customer gateway.
        /// The only supported connection type is ipsec.1.
        /// </summary>
        /// <remarks>
        /// The response includes information that you need to configure your customer gateway, in XML format.
        /// 
        /// It is strongly recommend that you use HTTPS when calling this operation because the response
        /// contains sensitive cryptographic information for configuring your customer gateway.
        /// If you shut down your VPN connection for any reason and later create a new VPN connection, you must
        /// reconfigure your customer gateway with the new information returned from CreateVpnConnection.
        /// </remarks>
        /// <param name="request">Create Vpn Connection  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Vpn Connection  Response from the service</returns>
        CreateVpnConnectionResponse CreateVpnConnection(CreateVpnConnectionRequest request);

        /// <summary>
        /// Gives you information about one or more sets of DHCP options. You can
        /// specify one or more DHCP options set IDs, or no IDs (to describe
        /// all your sets of DHCP options).
        /// </summary>
        /// <remarks>
        /// The returned information consists of:
        /// 1. The DHCP options set ID
        /// 2. The options
        /// </remarks>
        /// <param name="request">Describe Dhcp Options  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Dhcp Options  Response from the service</returns>
        DescribeDhcpOptionsResponse DescribeDhcpOptions(DescribeDhcpOptionsRequest request);

        /// <summary>
        /// Creates a set of DHCP options that you can then associate with one or more VPCs, causing all
        /// existing and new instances that you launch in those VPCs to use the set of DHCP options.
        /// </summary>
        /// <remarks>
        /// The following are DHCP options you can specify.
        ///
        /// Options:
        /// 1. domain-name
        /// A domain name of your choice (e.g., mydomain.com).
        ///
        /// 2. domain-name-servers
        /// The IP address of a domain name server (e.g., 10.2.5.1).
        /// You can specify up to four addresses.
        ///
        /// 3. ntp-servers
        /// The IP address of a Network Time Protocol (NTP)
        /// server (e.g., 10.4.6.1). You can specify up to four addresses.
        ///
        /// 4. netbios-name-servers
        /// The IP address of a NetBIOS name server (e.g., 10.8.9.5).
        /// You can specify up to four addresses.
        ///
        /// 5. netbios-node-type
        /// Value indicating the NetBIOS node type (1, 2, 4, or 8).
        /// </remarks>
        /// <param name="request">Create Dhcp Options  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Dhcp Options  Response from the service</returns>
        CreateDhcpOptionsResponse CreateDhcpOptions(CreateDhcpOptionsRequest request);

        /// <summary>
        /// Creates a Spot Instance request.
        /// </summary>
        /// <remarks>
        /// Spot Instances are instances that Amazon EC2 starts on your behalf
        /// when the maximum price that you specify exceeds the current Spot Price.
        /// Amazon EC2 periodically sets the Spot Price based on available
        /// Spot Instance capacity and current Spot Instance requests.
        /// </remarks>
        /// <param name="request">Request Spot Instances  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Request Spot Instances  Response from the service</returns>
        RequestSpotInstancesResponse RequestSpotInstances(RequestSpotInstancesRequest request);

        /// <summary>
        /// Describes the Spot Instance requests that belong to your account.
        /// </summary>
        /// <remarks>
        /// Spot Instances are instances that automatically launch
        /// when your request price exceeds that Spot Price
        /// that Amazon EC2 periodically calculates.
        /// </remarks>
        /// <param name="request">Describe Spot Instance Requests  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Spot Instance Requests  Response from the service</returns>
        DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest request);

        /// <summary>
        /// Cancels one or more Spot Instance requests.
        /// </summary>
        /// <remarks>
        /// Spot Instances are instances that Amazon EC2 starts on your behalf when the
        /// maximum price that you specify exceeds the current Spot Price.
        /// Amazon EC2 periodically sets the Spot Price based on available Spot Instance
        /// capacity and current Spot Instance requests.
        /// </remarks>
        /// <param name="request">Cancel Spot Instance Requests  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Cancel Spot Instance Requests  Response from the service</returns>
        CancelSpotInstanceRequestsResponse CancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest request);

        /// <summary>
        /// Describes the Spot Price history.
        /// </summary>
        /// <param name="request">Describe Spot Price History  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Spot Price History  Response from the service</returns>
        DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest request);

        /// <summary>
        /// Creates the datafeed for Spot Instances, enabling you to view Spot Instance usage logs.
        /// You can create one data feed per account.
        /// </summary>
        /// <param name="request">Create Spot Datafeed Subscription  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Spot Datafeed Subscription  Response from the service</returns>
        CreateSpotDatafeedSubscriptionResponse CreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest request);

        /// <summary>
        /// Describes the datafeed for Spot Instances.
        /// </summary>
        /// <param name="request">Describe Spot Datafeed Subscription  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Spot Datafeed Subscription  Response from the service</returns>
        DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest request);

        /// <summary>
        /// Deletes the datafeed for Spot Instances.
        /// </summary>
        /// <param name="request">Delete Spot Datafeed Subscription  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Spot Datafeed Subscription  Response from the service</returns>
        DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest request);

        /// <summary>
        /// Cancels an active conversion task.
        /// The task can be the import of an instance or volume.
        /// </summary>
        /// <remarks>
        /// The command removes all artifacts of the conversion, including a partially uploaded volume or instance.
        /// If the conversion is complete or is in the process of transferring the final disk image,
        /// the command fails and returns an exception.
        /// </remarks>
        /// <param name="request">Cancel Conversion Task  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Cancel Conversion Task  Response from the service</returns>
        CancelConversionTaskResponse CancelConversionTask(CancelConversionTaskRequest request);

        /// <summary>
        /// Describes your conversion tasks.
        /// For more information, go to Importing Your Virtual Machines and Volumes into Amazon EC2 in the Amazon Elastic Compute Cloud User Guide.
        /// </summary>
        /// <param name="request">Describe Conversion Tasks  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Conversion Tasks  Response from the service</returns>
        DescribeConversionTasksResponse DescribeConversionTasks(DescribeConversionTasksRequest request);

        /// <summary>
        /// Creates a new import instance task using metadata from the specified disk image.
        /// </summary>
        /// <param name="request">Import Instance  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Import Instance  Response from the service</returns>
        ImportInstanceResponse ImportInstance(ImportInstanceRequest request);

        /// <summary>
        /// Creates a new import volume task using metadata from the specified disk image.
        /// </summary>
        /// <param name="request">Import Volume  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Import Volume  Response from the service</returns>
        ImportVolumeResponse ImportVolume(ImportVolumeRequest request);

        /// <summary>
        /// Adds one or more egress rules to a VPC security group.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This call permits instances in a security group to send traffic to one or more destination
        /// CIDR IP address ranges, or to one or more destination security groups in the same VPC.
        /// </para>
        /// <para>
        /// This action applies only to security groups in a VPC; it's not supported for standard (EC2) security groups.
        /// </para>
        /// <para>
        /// Each rule consists of the protocol (e.g., TCP), plus either a CIDR range, or a source group. For the TCP
        /// and UDP protocols, you must also specify the destination port or port range. For the ICMP protocol, you
        /// must also specify the ICMP type and code.You can use -1 as a wildcard for the ICMP type or code.
        /// </para>
        /// <para>
        /// Rule changes are propagated to instances within the security group as quickly as possible. However, a
        /// small delay might occur.
        /// </para>
        /// </remarks>
        /// <param name="request">Authorize Security Group Egress  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Authorize Security Group Egress  Response from the service</returns>
        AuthorizeSecurityGroupEgressResponse AuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest request);

        /// <summary>
        /// Removes one or more egress rules from a VPC security group. 
        /// </summary>
        /// <remarks>
        /// This action applies only to security groups in a VPC. It doesn't work with standard (EC2) security groups.
        /// For information about Amazon Virtual Private Cloud and VPC security groups, go to the Amazon Virtual
        /// Private Cloud User Guide.
        /// 
        /// The values that you specify in the revoke request (e.g., ports, etc.) must match the existing rule's values
        /// in order for the rule to be revoked.
        /// 
        /// Each rule consists of the protocol, and the CIDR range or destination security group. For the TCP and
        /// UDP protocols, you must also specify the destination port or range of ports. For the ICMP protocol, you
        /// must also specify the ICMP type and code.
        /// 
        /// Rule changes are propagated to instances within the security group as quickly as possible. However, a
        /// small delay might occur.
        /// </remarks>
        /// <param name="request">Revoke Security Group Egress  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Revoke Security Group Egress  Response from the service</returns>
        RevokeSecurityGroupEgressResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request);

        /// <summary>
        /// Creates a new Internet gateway in your AWS account. After creating the Internet gateway, you attach
        /// it to a VPC using AttachInternetGateway.
        /// </summary>
        /// <param name="request">Create Internet Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Internet Gateway  Response from the service</returns>
        CreateInternetGatewayResponse CreateInternetGateway(CreateInternetGatewayRequest request);

        /// <summary>
        /// Gives you information about your Internet gateways.
        /// </summary>
        /// <remarks>
        /// You can filter the results to return information only
        /// about Internet gateways that match criteria you specify.
        /// For example, you could get information only
        /// about gateways with particular tags.
        /// The Internet gateway must match at least one of the specified values
        /// for it to be included in the results.
        /// 
        /// You can specify multiple filters (e.g., the Internet gateway is
        /// attached to a particular VPC and is tagged with a particular value).
        /// The result includes information for a particular Internet gateway
        /// only if the gateway matches all your filters.
        /// 
        /// If there's no match, no special message is returned; the response is simply empty.
        /// 
        /// You can use wildcards with the filter values:
        /// * matches zero or more characters, and ? matches exactly one character.
        /// 
        /// You can escape special characters using a backslash before the character. For example,
        /// a value of \*amazon\?\\ searches for the literal string *amazon?\.
        /// </remarks>
        /// <param name="request">Describe Internet Gateways  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Internet Gateways  Response from the service</returns>
        DescribeInternetGatewaysResponse DescribeInternetGateways(DescribeInternetGatewaysRequest request);

        /// <summary>
        /// Deletes an Internet gateway from your AWS account. The gateway must not be attached to a VPC. For
        /// more information about your VPC and Internet gateway, go to Amazon Virtual Private Cloud User Guide.
        /// </summary>
        /// <param name="request">Delete Internet Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Internet Gateway  Response from the service</returns>
        DeleteInternetGatewayResponse DeleteInternetGateway(DeleteInternetGatewayRequest request);

        /// <summary>
        /// Attaches an Internet gateway to a VPC, enabling connectivity between the Internet and the VPC.
        /// </summary>
        /// <param name="request">Attach Internet Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Attach Internet Gateway  Response from the service</returns>
        AttachInternetGatewayResponse AttachInternetGateway(AttachInternetGatewayRequest request);

        /// <summary>
        /// Detaches an Internet gateway from a VPC, disabling connectivity
        /// between the Internet and the VPC.
        /// </summary>
        /// <remarks>
        /// The VPC must not contain any running instances with elastic IP
        /// addresses. For more information about your VPC and Internet gateway,
        /// go to Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        /// <param name="request">Detach Internet Gateway  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Detach Internet Gateway  Response from the service</returns>
        DetachInternetGatewayResponse DetachInternetGateway(DetachInternetGatewayRequest request);

        /// <summary>
        /// Creates a route table within a VPC.
        /// After you create a new route table, you can add routes and associate the table with a subnet.
        /// </summary>
        /// <param name="request">Create Route Table  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Route Table  Response from the service</returns>
        CreateRouteTableResponse CreateRouteTable(CreateRouteTableRequest request);

        /// <summary>
        /// Gives you information about your route tables.
        /// </summary>
        /// <remarks>
        /// You can filter the results to return information only about
        /// tables that match criteria you specify. For example, you
        /// could get information only about a table associated with a
        /// particular subnet.You can specify multiple values for the filter.
        /// The table must match at least one of the specified values for
        /// it to be included in the results.
        /// 
        /// You can specify multiple filters (e.g., the table has a
        /// particular route, and is associated with a particular subnet).
        /// The result includes information for a particular table only if
        /// it matches all your filters. If there's no match, no special
        /// message is returned; the response is simply empty.
        /// 
        /// You can use wildcards with the filter values: * matches zero or
        /// more characters, and ? matches exactly one character.
        /// You can escape special characters using a backslash before the
        /// character. For example, a value of \*amazon\?\\ searches for the
        /// literal string *amazon?\.
        /// </remarks>
        /// <param name="request">Describe Route Tables  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Route Tables  Response from the service</returns>
        DescribeRouteTablesResponse DescribeRouteTables(DescribeRouteTablesRequest request);

        /// <summary>
        /// Deletes a route table from a VPC. The route table must not be associated with a subnet.
        /// You can't delete the main route table.
        /// </summary>
        /// <param name="request">Delete Route Table  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Route Table  Response from the service</returns>
        DeleteRouteTableResponse DeleteRouteTable(DeleteRouteTableRequest request);

        /// <summary>
        /// Associates a subnet with a route table.
        /// </summary>
        /// <remarks>
        /// The subnet and route table must be in the same VPC. This
        /// association causes traffic originating from the subnet
        /// to be routed according to the routes in the route table.
        /// The action returns an association ID, which you need if
        /// you want to disassociate the route table from the subnet
        /// later. A route table can be associated with multiple subnets.
        /// </remarks>
        /// <param name="request">Associate Route Table  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Associate Route Table  Response from the service</returns>
        AssociateRouteTableResponse AssociateRouteTable(AssociateRouteTableRequest request);

        /// <summary>
        /// Changes the route table associated with a given subnet in a VPC.
        /// </summary>
        /// <remarks>
        /// After you execute this action, the subnet uses the routes in the
        /// new route table it's associated with. For more information about
        /// route tables, go to Route Tables in the Amazon Virtual Private
        /// Cloud User Guide.
        /// </remarks>
        /// <param name="request">Replace Route Table Association  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Replace Route Table Association  Response from the service</returns>
        ReplaceRouteTableAssociationResponse ReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest request);

        /// <summary>
        /// Disassociates a subnet from a route table.
        /// </summary>
        /// <remarks>
        /// After you perform this action, the subnet no longer
        /// uses the routes in the route table. Instead it uses
        /// the routes in the VPC's main route table.
        /// For more information about route tables, go to Route
        /// Tables in the Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        /// <param name="request">Disassociate Route Table  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Disassociate Route Table  Response from the service</returns>
        DisassociateRouteTableResponse DisassociateRouteTable(DisassociateRouteTableRequest request);

        /// <summary>
        /// Creates a new route in a route table within a VPC.
        /// The route's target can be either a gateway attached
        /// to the VPC or a NAT instance in the VPC.
        /// </summary>
        /// <remarks>
        /// When determining how to route traffic, we use the route
        /// with the most specific match. For example, let's say the
        /// traffic is destined for 192.0.2.3, and the route table
        /// includes the following two routes:
        /// 192.0.2.0/24 (goes to some target A)
        /// 192.0.2.0/28 (goes to some target B)
        /// 
        /// Both routes apply to the traffic destined for 192.0.2.3.
        /// However, the second route in the list is more specific,
        /// so we use that route to determine where to target the traffic.
        /// 
        /// For more information about route tables, go to Route
        /// Tables in the Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        /// <param name="request">Create Route  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Route  Response from the service</returns>
        CreateRouteResponse CreateRoute(CreateRouteRequest request);

        /// <summary>
        /// Replaces an existing route within a route table in a VPC.
        /// </summary>
        /// <remarks>
        /// For more information about route tables, go to Route Tables
        /// in the Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        /// <param name="request">Replace Route  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Replace Route  Response from the service</returns>
        ReplaceRouteResponse ReplaceRoute(ReplaceRouteRequest request);

        /// <summary>
        /// Deletes a route from a route table in a VPC.
        /// </summary>
        /// <param name="request">Delete Route  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Route  Response from the service</returns>
        DeleteRouteResponse DeleteRoute(DeleteRouteRequest request);

        /// <summary>
        /// Creates a network ACL in a VPC.
        /// </summary>
        /// <remarks>
        /// Network ACLs provide an optional layer of security (on top of security groups)
        /// for the instances in your VPC.
        /// </remarks>
        /// <param name="request">Create Network Acl  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Network Acl  Response from the service</returns>
        CreateNetworkAclResponse CreateNetworkAcl(CreateNetworkAclRequest request);

        /// <summary>
        /// Gives you information about the network ACLs in your VPC.
        /// </summary>
        /// <remarks>
        /// You can filter the results to return information only about ACLs
        /// that match criteria you specify. For example, you could get information
        /// for only the ACL associated with a particular subnet.
        /// The ACL must match at least one of the specified values for it to be
        /// included in the results.
        /// 
        /// You can specify multiple filters (e.g., the ACL is associated with
        /// a particular subnet and has an egress entry that denies traffic to
        /// a particular port). The result includes information for a particular
        /// ACL only if it matches all your filters. If there's no match, no
        /// special message is returned; the response is simply empty.
        /// 
        /// You can use wildcards with the filter values: * matches zero or more
        /// characters, and ? matches exactly one character.You can escape special
        /// characters using a backslash before the character. For example,
        /// a value of \*amazon\?\\ searches for the literal string *amazon?\.
        /// </remarks>
        /// <param name="request">Describe Network Acls  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Network Acls  Response from the service</returns>
        DescribeNetworkAclsResponse DescribeNetworkAcls(DescribeNetworkAclsRequest request);

        /// <summary>
        /// Deletes a network ACL from a VPC.
        /// </summary>
        /// <remarks>
        /// The ACL must not have any subnets associated with it.
        /// You can't delete the default network ACL. For more
        /// information about network ACLs, go to Network ACLs in the
        /// Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        /// <param name="request">Delete Network Acl  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Network Acl  Response from the service</returns>
        DeleteNetworkAclResponse DeleteNetworkAcl(DeleteNetworkAclRequest request);

        /// <summary>
        /// Changes which network ACL a subnet is associated with.
        /// </summary>
        /// <remarks>
        /// By default when you create a subnet, it's automatically associated with the
        /// default network ACL. For more information about network ACLs, go to
        /// Network ACLs in the Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        /// <param name="request">Replace Network Acl Association  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Replace Network Acl Association  Response from the service</returns>
        ReplaceNetworkAclAssociationResponse ReplaceNetworkAclAssociation(ReplaceNetworkAclAssociationRequest request);

        /// <summary>
        /// Creates an entry (i.e., rule) in a network ACL with a rule number you specify.
        /// </summary>
        /// <remarks>
        /// Each network ACL has a set of numbered ingress rules and a separate set of numbered egress rules.
        /// When determining whether a packet should be allowed in or out of a subnet associated with the ACL,
        /// Amazon VPC processes the entries in the ACL according to the rule numbers, in ascending order.
        ///
        /// We recommend that you leave room between the rules (e.g., 100, 110, 120, etc.), and not number
        /// them sequentially (101, 102, 103, etc.). This allows you to easily add a new rule between existing
        /// ones without having to renumber the rules.
        ///
        /// After you add an entry, you can't modify it; you must either replace it, or create a new entry and delete
        /// the old one.
        /// </remarks>
        /// <param name="request">Create Network Acl Entry  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Network Acl Entry  Response from the service</returns>
        CreateNetworkAclEntryResponse CreateNetworkAclEntry(CreateNetworkAclEntryRequest request);

        /// <summary>
        /// Replaces an entry (i.e., rule) in a network ACL.
        /// </summary>
        /// <remarks>
        /// For more information about network ACLs, go to Network ACLs in the Amazon
        /// Virtual Private Cloud User Guide.
        /// </remarks>
        /// <param name="request">Replace Network Acl Entry  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Replace Network Acl Entry  Response from the service</returns>
        ReplaceNetworkAclEntryResponse ReplaceNetworkAclEntry(ReplaceNetworkAclEntryRequest request);

        /// <summary>
        /// Deletes an ingress or egress entry (i.e., rule) from a network ACL.
        /// </summary>
        /// <remarks>
        /// For more information about network ACLs, go to Network ACLs
        /// in the Amazon Virtual Private Cloud User Guide.
        /// </remarks>
        /// <param name="request">Delete Network Acl Entry  request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Network Acl Entry  Response from the service</returns>
        DeleteNetworkAclEntryResponse DeleteNetworkAclEntry(DeleteNetworkAclEntryRequest request);

        /// <summary>
        /// Attaches a network interface to an instance.
        /// </summary>
        /// <param name="request">Attach Network Interface request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Attach Network Interface response from the service</returns>
        AttachNetworkInterfaceResponse AttachNetworkInterface(AttachNetworkInterfaceRequest request);

        /// <summary>
        /// Creates a network interface in the specified subnet.
        /// </summary>
        /// <remarks>
        /// This action is supported only in Amazon VPC.
        /// </remarks>
        /// <param name="request">Create Network Interface request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Network Interface response from the service</returns>
        CreateNetworkInterfaceResponse CreateNetworkInterface(CreateNetworkInterfaceRequest request);

        /// <summary>
        /// Deletes the specified network interface.
        /// </summary>
        /// <param name="request">Delete Network Interface request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Network Interface response from the service</returns>
        DeleteNetworkInterfaceResponse DeleteNetworkInterface(DeleteNetworkInterfaceRequest request);

        /// <summary>
        /// Describes a Network Interface Attribute.
        /// Only one attribute can be specified per call.
        /// </summary>
        /// <remarks>Only one attribute can be specified per call.</remarks>
        /// <param name="request">Describe Network Interface Attribute request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Network Interface Attribute response from the service</returns>
        DescribeNetworkInterfaceAttributeResponse DescribeNetworkInterfaceAttribute(DescribeNetworkInterfaceAttributeRequest request);

        /// <summary>
        /// Describes one or more Network Interfaces.
        /// </summary>
        /// <param name="request">Describe Network Interfaces request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Network Interfaces response from the service</returns>
        DescribeNetworkInterfacesResponse DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest request);

        /// <summary>
        /// Detaches a network interface from an instance.
        /// </summary>
        /// <param name="request">Detach Network Interface request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Detach Network Interface response from the service</returns>
        DetachNetworkInterfaceResponse DetachNetworkInterface(DetachNetworkInterfaceRequest request);

        /// <summary>
        /// Modifies a network interface attribute. Only one attribute can be specified per call.
        /// </summary>
        /// <remarks>Only one attribute can be specified per call.</remarks>
        /// <param name="request">Modify Network Interface Attribute request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Modify Network Interface Attribute response from the service</returns>
        ModifyNetworkInterfaceAttributeResponse ModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest request);

        /// <summary>
        /// Reset Network Interface Attribute request
        /// </summary>
        /// <remarks>Only one attribute can be specified per call.</remarks>
        /// <param name="request">Reset Network Interface Attribute request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Reset Network Interface Attribute response from the service</returns>
        ResetNetworkInterfaceAttributeResponse ResetNetworkInterfaceAttribute(ResetNetworkInterfaceAttributeRequest request);

        /// <summary>
        /// Returns the status of one or more volumes.
        /// </summary>
        /// <param name="request">Describe Volume Status request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Volume Status response from the service</returns>
        DescribeVolumeStatusResponse DescribeVolumeStatus(DescribeVolumeStatusRequest request);

        /// <summary>
        /// Enables I/O operations for a volume that had I/O operations disabled
        /// because the data on the volume was potentially inconsistent.
        /// </summary>
        /// <param name="request">Enable Volume IO request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Enable Volume IO response from the service</returns>
        EnableVolumeIOResponse EnableVolumeIO(EnableVolumeIORequest request);

        /// <summary>
        /// Modifies a volume attribute.
        /// </summary>
        /// <param name="request">Modify Volume Attribute request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Modify Volume Attribute response from the service</returns>
        ModifyVolumeAttributeResponse ModifyVolumeAttribute(ModifyVolumeAttributeRequest request);

        /// <summary>
        /// Describes an attribute of a volume.
        /// </summary>
        /// <param name="request">Describe Volume Attribute request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Volume Attribute response from the service</returns>
        DescribeVolumeAttributeResponse DescribeVolumeAttribute(DescribeVolumeAttributeRequest request);

        /// <summary>
        /// Assigns one or more secondary private IP addresses to a network interface in Amazon VPC.
        /// </summary>
        /// <remarks>
        /// You can specify one or more specific secondary IP addresses that you want to assign,
        /// or you can specify a number of secondary IP addresses to be automatically assigned
        /// within the subnet’s CIDR block range.
        /// The number of secondary IP addresses that you can assign to an instance varies by instance type.
        /// </remarks>
        /// <param name="request">Assign Private Ip Addresses request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Assign Private Ip Addresses response from the service</returns>
        AssignPrivateIpAddressesResponse AssignPrivateIpAddresses(AssignPrivateIpAddressesRequest request);

        /// <summary>
        /// Unassigns one or more secondary private IP addresses from a network
        /// interface in Amazon VPC.
        /// This command is only available in Amazon VPC
        /// </summary>
        /// <param name="request">Unassign Private Ip Addresses request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Unassign Private Ip Addresses response from the service</returns>
        UnassignPrivateIpAddressesResponse UnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest request);

        /// <summary>
        /// Creates a new static route associated with a VPN connection between an existing virtual private gateway
        /// and a VPN customer gateway. The static route allows traffic to be routed from the virtual private gateway
        /// to the VPN customer gateway.
        /// </summary>
        /// <remarks>
        /// We strongly recommend you use HTTPS when calling this operation because the response
        /// contains sensitive cryptographic information for configuring your customer gateway.
        /// </remarks>
        /// <param name="request">Create Vpn Connection Route request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Vpn Connection Route response from the service</returns>
        CreateVpnConnectionRouteResponse CreateVpnConnectionRoute(CreateVpnConnectionRouteRequest request);

        /// <summary>
        /// Deletes a static route associated with a VPN connection between an existing virtual private gateway and
        /// a VPN customer gateway. The static route allows traffic to be routed from the virtual private gateway to
        /// the VPN customer gateway.
        /// </summary>
        /// <remakrs>
        /// We strongly recommend you use HTTPS when calling this operation because the response
        /// contains sensitive cryptographic information for configuring your customer gateway.
        /// </remakrs>
        /// <param name="request">Delete Vpn Connection Route request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Delete Vpn Connection Route response from the service</returns>
        DeleteVpnConnectionRouteResponse DeleteVpnConnectionRoute(DeleteVpnConnectionRouteRequest request);

        /// <summary>
        /// Enables a virtual private gateway (VGW) to propagate routes to the
        /// routing tables of an Amazon VPC.
        /// </summary>
        /// <param name="request">Enable Virtual Gateway Route Propagation request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Enable Virtual Gateway Route Propagation response from the service</returns>
        EnableVGWRoutePropagationResponse EnableVGWRoutePropagation(EnableVGWRoutePropagationRequest request);

        /// <summary>
        /// Disables a virtual private gateway (VGW) from propagating routes to
        /// the routing tables of an Amazon VPC.
        /// </summary>
        /// <param name="request">Disable Virtual Gateway Route Propagation request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Disable Virtual Gateway Route Propagation response from the service</returns>
        DisableVGWRoutePropagationResponse DisableVGWRoutePropagation(DisableVGWRoutePropagationRequest request);

        /// <summary>
        /// Cancels the specified Reserved Instance listing in the Reserved Instance Marketplace.
        /// </summary>
        /// <param name="request">Cancel Reserved Instances Listing request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Cancel Reserved Instances Listing response from the service</returns>
	    CancelReservedInstancesListingResponse CancelReservedInstancesListing(CancelReservedInstancesListingRequest request);

        /// <summary>
        /// Creates a new listing for Amazon EC2 Reserved Instances that will be sold in
        /// the Reserved Instance Marketplace. You can submit one Reserved Instance listing
        /// at a time.
        /// </summary>
        /// <remarks>
        /// The Reserved Instance Marketplace matches sellers who want to resell Reserved Instance
        /// capacity that they no longer need with buyers who want to purchase additional capacity.
        /// Reserved Instances bought and sold through the Reserved Instance Marketplace work
        /// like any other Reserved Instances.
        /// 
        /// If you want to sell your Reserved Instances, you must first register as a Seller in
        /// the Reserved Instance Marketplace. After completing the registration process, you can
        /// create a Reserved Instance Marketplace listing of some or all of your Reserved Instances,
        /// and specify the upfront price you want to receive for them.
        /// Your Reserved Instance listings then become available for purchase.
        /// </remarks>
        /// <param name="request">Create Reserved Instances Listing request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Create Reserved Instances Listing response from the service</returns>
        CreateReservedInstancesListingResponse CreateReservedInstancesListing(CreateReservedInstancesListingRequest request);

        /// <summary>
        /// Describes your account's Reserved Instance listings in the Reserved Instance Marketplace.
        /// </summary>
        /// <param name="request">Describe Reserved Instances Listing request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Reserved Instances Listing response from the service</returns>
        DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings(DescribeReservedInstancesListingsRequest request);

        /// <summary>
        /// Copies a snapshot from a source region to the current region.
        /// </summary>
        /// <param name="request">Copy Snapshot request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Copy Snapshot response from the service</returns>
        CopySnapshotResponse CopySnapshot(CopySnapshotRequest request);

        /// <summary>
        /// Copies a image from a source region to the current region.
        /// </summary>
        /// <param name="request">Copy Image request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Copy Image response from the service</returns>
        CopyImageResponse CopyImage(CopyImageRequest request);

        /// <summary>
        /// Describes VPC attributes.
        /// </summary>
        /// <param name="request">Describe Vpc Attributes Request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Vpc Attributes response from the service</returns>
        DescribeVpcAttributeResponse DescribeVpcAttribute(DescribeVpcAttributeRequest request);

        /// <summary>
        /// Modified attributes on a VPC.
        /// </summary>
        /// <param name="request">Modify Vpc Attributes Request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Modify Vpc Attributes response from the service</returns>
        ModifyVpcAttributeResponse ModifyVpcAttribute(ModifyVpcAttributeRequest request);

        /// <summary>
        /// Describes account attributes of the caller
        /// </summary>
        /// <param name="request">Describe Account Attributes Request</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.EC2.AmazonEC2Exception"></exception>
        /// <returns>Describe Account Attributes response from the service</returns>
        DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request);
    }
}
