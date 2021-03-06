// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> The VpnServerConfigurations service client. </summary>
    public partial class VpnServerConfigurationsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal VpnServerConfigurationsRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of VpnServerConfigurationsOperations for mocking. </summary>
        protected VpnServerConfigurationsOperations()
        {
        }
        /// <summary> Initializes a new instance of VpnServerConfigurationsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal VpnServerConfigurationsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new VpnServerConfigurationsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Retrieves the details of a VpnServerConfiguration. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VpnServerConfiguration>> GetAsync(string resourceGroupName, string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, vpnServerConfigurationName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a VpnServerConfiguration. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VpnServerConfiguration> Get(string resourceGroupName, string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, vpnServerConfigurationName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates VpnServerConfiguration tags. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being updated. </param>
        /// <param name="vpnServerConfigurationParameters"> Parameters supplied to update VpnServerConfiguration tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VpnServerConfiguration>> UpdateTagsAsync(string resourceGroupName, string vpnServerConfigurationName, TagsObject vpnServerConfigurationParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationsOperations.UpdateTags");
            scope.Start();
            try
            {
                return await RestClient.UpdateTagsAsync(resourceGroupName, vpnServerConfigurationName, vpnServerConfigurationParameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates VpnServerConfiguration tags. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being updated. </param>
        /// <param name="vpnServerConfigurationParameters"> Parameters supplied to update VpnServerConfiguration tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VpnServerConfiguration> UpdateTags(string resourceGroupName, string vpnServerConfigurationName, TagsObject vpnServerConfigurationParameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationsOperations.UpdateTags");
            scope.Start();
            try
            {
                return RestClient.UpdateTags(resourceGroupName, vpnServerConfigurationName, vpnServerConfigurationParameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all the vpnServerConfigurations in a resource group. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual AsyncPageable<VpnServerConfiguration> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<VpnServerConfiguration>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VpnServerConfiguration>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all the vpnServerConfigurations in a resource group. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public virtual Pageable<VpnServerConfiguration> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<VpnServerConfiguration> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroup(resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VpnServerConfiguration> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationsOperations.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroupNextPage(nextLink, resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all the VpnServerConfigurations in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<VpnServerConfiguration> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VpnServerConfiguration>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VpnServerConfiguration>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all the VpnServerConfigurations in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<VpnServerConfiguration> List(CancellationToken cancellationToken = default)
        {
            Page<VpnServerConfiguration> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VpnServerConfiguration> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Creates a VpnServerConfiguration resource if it doesn&apos;t exist else updates the existing VpnServerConfiguration. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being created or updated. </param>
        /// <param name="vpnServerConfigurationParameters"> Parameters supplied to create or update VpnServerConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="vpnServerConfigurationName"/>, or <paramref name="vpnServerConfigurationParameters"/> is null. </exception>
        public virtual async Task<VpnServerConfigurationsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string vpnServerConfigurationName, VpnServerConfiguration vpnServerConfigurationParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vpnServerConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationName));
            }
            if (vpnServerConfigurationParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, vpnServerConfigurationName, vpnServerConfigurationParameters, cancellationToken).ConfigureAwait(false);
                return new VpnServerConfigurationsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, vpnServerConfigurationName, vpnServerConfigurationParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a VpnServerConfiguration resource if it doesn&apos;t exist else updates the existing VpnServerConfiguration. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being created or updated. </param>
        /// <param name="vpnServerConfigurationParameters"> Parameters supplied to create or update VpnServerConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="vpnServerConfigurationName"/>, or <paramref name="vpnServerConfigurationParameters"/> is null. </exception>
        public virtual VpnServerConfigurationsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string vpnServerConfigurationName, VpnServerConfiguration vpnServerConfigurationParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vpnServerConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationName));
            }
            if (vpnServerConfigurationParameters == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, vpnServerConfigurationName, vpnServerConfigurationParameters, cancellationToken);
                return new VpnServerConfigurationsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, vpnServerConfigurationName, vpnServerConfigurationParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a VpnServerConfiguration. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="vpnServerConfigurationName"/> is null. </exception>
        public virtual async Task<VpnServerConfigurationsDeleteOperation> StartDeleteAsync(string resourceGroupName, string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vpnServerConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, vpnServerConfigurationName, cancellationToken).ConfigureAwait(false);
                return new VpnServerConfigurationsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, vpnServerConfigurationName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a VpnServerConfiguration. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration being deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="vpnServerConfigurationName"/> is null. </exception>
        public virtual VpnServerConfigurationsDeleteOperation StartDelete(string resourceGroupName, string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vpnServerConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(vpnServerConfigurationName));
            }

            using var scope = _clientDiagnostics.CreateScope("VpnServerConfigurationsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, vpnServerConfigurationName, cancellationToken);
                return new VpnServerConfigurationsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, vpnServerConfigurationName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
